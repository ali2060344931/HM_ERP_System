using System;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using HM_ERP_System.Class_General;

/// <summary>
///WeakReference کلاس کمکی برای مدیریت نمایش فرم های والد با پشتیبانی بهتر از سازنده های مختلف و
/// </summary>
public static class FormManager
{
    // از یک Dictionary برای نگهداری WeakReference از نمونه های فعال فرم ها استفاده می کنیم.
    private static readonly System.Collections.Generic.Dictionary<Type, WeakReference> _activeForms = new System.Collections.Generic.Dictionary<Type, WeakReference>();

    public static void ShowMdiChildForm<TForm>(
        Form mdiParent,
        Form activeMdiChild = null)
        where TForm : Form
    {
        // 1. بررسی فعال بودن نمونه فرم
        TForm formToShow = null;
        Type formType = typeof(TForm);

        if (_activeForms.ContainsKey(formType) && _activeForms[formType].IsAlive)
        {
            // نمونه فعال وجود دارد، آن را بازیابی می کنیم.
            formToShow = _activeForms[formType].Target as TForm;
        }

        // ⚡️ اصلاح کلیدی: بررسی کنیم آیا نمونه بازیابی شده نال نیست و DISPOSED نشده است.
        if (formToShow != null && !formToShow.IsDisposed)
        {
            // اگر فرم فعال و دیسپوز نشده است، آن را به جلو می آوریم.
            formToShow.BringToFront();
            return;
        }
        else if (formToShow != null && formToShow.IsDisposed)
        {
            // 🗑️ اگر فرم Disposed شده است، مرجع آن را از دیکشنری حذف می کنیم تا نمونه جدید ساخته شود.
            _activeForms.Remove(formType);
            formToShow = null; // برای اطمینان از ساخت نمونه جدید در مراحل بعدی
        }

        // 2. منطق ایجاد نمونه جدید
        try
        {
            IUpdatableForms updatable = activeMdiChild as IUpdatableForms;
            object[] constructorArgs = null;

            // الف: تلاش برای یافتن و فراخوانی سازنده با پارامتر IUpdatableForms
            if (updatable != null)
            {
                ConstructorInfo ctorWithUpdatable = formType.GetConstructor(new Type[] { typeof(IUpdatableForms) });

                if (ctorWithUpdatable != null)
                {
                    // سازنده مناسب پیدا شد و updatable هم موجود است.
                    constructorArgs = new object[] { updatable };
                    formToShow = (TForm)Activator.CreateInstance(formType, constructorArgs);
                }
            }

            // ب: اگر هنوز فرم ایجاد نشده است (سازنده با updatable یا پیدا نشد یا updatable نال بود)
            if (formToShow == null)
            {
                // تلاش برای استفاده از سازنده بدون پارامتر (Default Constructor)
                ConstructorInfo ctorNoParams = formType.GetConstructor(Type.EmptyTypes);

                if (ctorNoParams != null)
                {
                    // سازنده بدون پارامتر موجود است.
                    formToShow = (TForm)Activator.CreateInstance(formType);
                }
                else
                {
                    // اگر سازنده بدون پارامتر وجود ندارد، و فرم فقط سازنده IUpdatableForms را دارد،
                    // پارامتر updatable را به عنوان null ارسال می کنیم تا خطای MissingMethodException ندهد.
                    ConstructorInfo ctorWithUpdatable = formType.GetConstructor(new Type[] { typeof(IUpdatableForms) });

                    if (ctorWithUpdatable != null)
                    {
                        formToShow = (TForm)Activator.CreateInstance(formType, new object[] { null });
                    }
                    else
                    {
                        // اگر هیچ یک از سازنده های مورد انتظار پیدا نشد، خطا می دهیم.
                        throw new MissingMethodException($"فرم {formType.Name} هیچ سازنده بدون پارامتر یا سازنده (IUpdatableForms) ندارد.");
                    }
                }
            }
        }
        catch (MissingMethodException ex)
        {
            MessageBox.Show($"خطا در ایجاد نمونه فرم {formType.Name}: {ex.Message}", "خطای سازنده", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            // اگر خطای 'Target of an invocation' (TargetInvocationException) رخ دهد، آن را گزارش می کنیم.
            string innerError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            MessageBox.Show($"خطا در ایجاد نمونه فرم {formType.Name}: Exception has been thrown by the target of an invocation.\nجزئیات خطا: {innerError}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 3. تنظیمات MDI و نمایش
        if (formToShow != null)
        {
            formToShow.MdiParent = mdiParent;
            formToShow.WindowState = FormWindowState.Maximized;
            formToShow.Show();

            // ذخیره نمونه جدید در دیکشنری
            _activeForms[formType] = new WeakReference(formToShow);
        }
    }
}