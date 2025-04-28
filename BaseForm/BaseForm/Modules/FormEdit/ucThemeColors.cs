using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm.Modules.FormEdit
{
    public partial class ucThemeColors : UserControl
    {
        public event Action<ThemeColors> ThemeChanged;

        public ucThemeColors(ThemeColors currentTheme)
        {
            InitializeComponent();

            ucColorPalatte.ThemeColor = currentTheme;
            ucColorPalatte.ThemeChanged += (theme) =>
            {
                ThemeChanged?.Invoke(theme);
            };
            
        }


        private void ucThemeColors_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonApply_Click(object sender, EventArgs e)
        {

        }

    }
}
