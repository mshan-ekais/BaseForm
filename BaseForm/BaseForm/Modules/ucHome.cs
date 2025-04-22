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
    public partial class ucHome : UserControl
    {
        private Label label2;

        public ucHome()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 50F);
            this.label2.Location = new System.Drawing.Point(379, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "ucHome";
            // 
            // ucHome
            // 
            this.Controls.Add(this.label2);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1051, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
