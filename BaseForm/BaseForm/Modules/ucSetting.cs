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
    public partial class ucSetting : UserControl
    {
        private Label label1;

        public ucSetting()
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
            this.label1.Location = new System.Drawing.Point(379, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 89);
            this.label1.TabIndex = 3;
            this.label1.Text = "ucSetting";
            // 
            // ucSetting
            // 
            this.Controls.Add(this.label1);
            this.Name = "ucSetting";
            this.Size = new System.Drawing.Size(1081, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
