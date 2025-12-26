using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Class_General
{
        public static class DynamicToolTip
        {
            // ToolTip سراسری برای همه فرم‌ها
            private static readonly ToolTip _toolTip;

            // Static constructor برای تنظیمات اولیه
            static DynamicToolTip()
            {
                _toolTip = new ToolTip
                {
                    AutoPopDelay = 5000,
                    InitialDelay = 500,
                    ReshowDelay = 200,
                    ShowAlways = true,
                    OwnerDraw = true // برای تغییر فونت و رنگ
                };

                // اتصال رویدادهای OwnerDraw
                _toolTip.Popup += ToolTip_Popup;
                _toolTip.Draw += ToolTip_Draw;
            }

            /// <summary>
            /// اتصال Tooltip پویا به تمام کنترل‌های فرم
            /// </summary>
            public static void Attach(Control parent)
            {
                foreach (Control ctrl in parent.Controls)
                {
                    ctrl.MouseHover -= Ctrl_MouseHover; // جلوگیری از اتصال دوباره
                    ctrl.MouseHover += Ctrl_MouseHover;

                    if (ctrl.HasChildren)
                        Attach(ctrl);
                }
            }

            // رویداد MouseHover برای کنترل‌ها
            private static void Ctrl_MouseHover(object sender, EventArgs e)
            {
                if (sender is Control ctrl && !string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    _toolTip.SetToolTip(ctrl, ctrl.Text);
                }
            }

            // تنظیم اندازه Tooltip بر اساس فونت دلخواه
            private static void ToolTip_Popup(object sender, PopupEventArgs e)
            {
                Font font = new Font("Tahoma", 11F, FontStyle.Regular);
                string text = _toolTip.GetToolTip(e.AssociatedControl);
                Size textSize = TextRenderer.MeasureText(text, font);
                e.ToolTipSize = new Size(textSize.Width + 10, textSize.Height + 6);
            }

            // رسم Tooltip با فونت و رنگ دلخواه
            private static void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
            {
                using (Font font = new Font("Tahoma", 11F))
                {
                    // پس‌زمینه
                    e.Graphics.FillRectangle(SystemBrushes.Info, e.Bounds);

                    // کادر دور Tooltip
                    e.Graphics.DrawRectangle(SystemPens.InfoText, e.Bounds);

                    // متن Tooltip
                    e.Graphics.DrawString(
                        e.ToolTipText,
                        font,
                        Brushes.Black,
                        new PointF(5, 3));
                }
            }
        }
    }

