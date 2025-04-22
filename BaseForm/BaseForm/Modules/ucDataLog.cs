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
    public partial class ucDataLog : UserControl
    {
        private Label label1;

        public ucDataLog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 50F);
            this.label1.Location = new System.Drawing.Point(397, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 89);
            this.label1.TabIndex = 3;
            this.label1.Text = "ucDataLog";
            // 
            // ucDataLog
            // 
            this.Controls.Add(this.label1);
            this.Name = "ucDataLog";
            this.Size = new System.Drawing.Size(1156, 646);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
