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
