using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm.Modules
{
    public partial class ucEditForm : UserControl
    {

        private ThemeColors _themeColor;

        public ThemeColors ThemeColor
        {
            get => _themeColor;
            set
            {
                _themeColor = value;
                ApplyTheme(_themeColor);  // ✅ 값을 할당할 때마다 함수 실행
            }
        }

        //BackColor = Color.FromArgb(120, 0, 0, 0), // 반투명 검정


        private void ApplyTheme(ThemeColors theme)
        {
            this.BackColor = theme.BackColor;

            foreach (var control in GetAllControls(this))
            {
                //if (control is Panel pnl)
                //{
                //    if (pnl.Tag != null && pnl.Tag.ToString() == "panelControlBar")
                //        pnl.BackColor = theme.TopPanelColor;
                //    else
                //        pnl.BackColor = theme.BackColor;
                //}

                if (control is Label lbl)
                    lbl.ForeColor = theme.FontColor;

                //if (control is Button btn)
                //{
                //    if (btn.Tag != null && btn.Tag.ToString() == "button")
                //    {
                //        btn.BackColor = theme.PointColor;
                //        btn.ForeColor = theme.FontColor;
                //    }
                //}
            }
        }

        public static IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                yield return child;

                foreach (Control grandChild in GetAllControls(child))
                {
                    yield return grandChild;
                }
            }
        }


        public ucEditForm()
        {
            InitializeComponent();
        }

        private void ucEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
