using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Text;
using System.Windows.Forms;

public static class DbContextExtensions
{
    public static bool SaveChangesSafe(this System.Data.Entity.DbContext ctx)
    {
        try
        {
            ctx.SaveChanges();
            return true;
        }
        catch (DbEntityValidationException ex)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("خطاهای اعتبارسنجی داده‌ها:");

            foreach (var eve in ex.EntityValidationErrors)
            {
                sb.AppendLine($"موجودیت: {eve.Entry.Entity.GetType().Name}");

                foreach (var ve in eve.ValidationErrors)
                    sb.AppendLine($" - {ve.PropertyName}: {ve.ErrorMessage}");
            }

            MessageBox.Show(sb.ToString(), "خطای اعتبارسنجی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        catch (DbUpdateException ex)
        {
            string msg = ex.InnerException?.InnerException?.Message
                         ?? ex.InnerException?.Message
                         ?? ex.Message;

            MessageBox.Show("خطای ذخیره‌سازی در دیتابیس:\n" + msg,"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطای سیستم:\n" + ex.Message,"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}
