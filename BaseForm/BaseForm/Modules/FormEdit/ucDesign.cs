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
    public partial class ucDesign : UserControl
    {
        public event Action<DockStyle> MenuStyleChanged;
        private DockStyle _currentMenuStyle;
        public ucDesign(DockStyle dockStyle)
        {
            InitializeComponent();
            _currentMenuStyle = dockStyle;

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            MenuStyleChanged?.Invoke(DockStyle.Right);
            //OnMenuStyleChanged(_currentMenuStyle);

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MenuStyleChanged?.Invoke(DockStyle.Left);
            //OnMenuStyleChanged(_currentMenuStyle);
        }

        private void OnMenuStyleChanged(DockStyle dockStyle)
        {
            MenuStyleChanged?.Invoke(dockStyle); // 이벤트 호출
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            MenuStyleChanged?.Invoke(DockStyle.Top);
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {

        }
    }
}
