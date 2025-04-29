
namespace BaseForm
{
    partial class BorderlessMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.iconButtonWindowMin = new FontAwesome.Sharp.IconButton();
            this.iconButtonWindowMax = new FontAwesome.Sharp.IconButton();
            this.iconButtonWindowClose = new FontAwesome.Sharp.IconButton();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 46);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1479, 833);
            this.panelControl.TabIndex = 8;
            this.panelControl.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelTopBar.Controls.Add(this.iconButtonWindowMin);
            this.panelTopBar.Controls.Add(this.iconButtonWindowMax);
            this.panelTopBar.Controls.Add(this.iconButtonWindowClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1479, 46);
            this.panelTopBar.TabIndex = 15;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBar_MouseDown);
            // 
            // iconButtonWindowMin
            // 
            this.iconButtonWindowMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonWindowMin.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonWindowMin.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowMin.IconSize = 25;
            this.iconButtonWindowMin.Location = new System.Drawing.Point(1299, 0);
            this.iconButtonWindowMin.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.iconButtonWindowMin.Name = "iconButtonWindowMin";
            this.iconButtonWindowMin.Size = new System.Drawing.Size(60, 46);
            this.iconButtonWindowMin.TabIndex = 14;
            this.iconButtonWindowMin.UseVisualStyleBackColor = false;
            this.iconButtonWindowMin.Click += new System.EventHandler(this.iconButtonWindowMin_Click);
            // 
            // iconButtonWindowMax
            // 
            this.iconButtonWindowMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonWindowMax.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonWindowMax.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowMax.IconSize = 25;
            this.iconButtonWindowMax.Location = new System.Drawing.Point(1359, 0);
            this.iconButtonWindowMax.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.iconButtonWindowMax.Name = "iconButtonWindowMax";
            this.iconButtonWindowMax.Size = new System.Drawing.Size(60, 46);
            this.iconButtonWindowMax.TabIndex = 13;
            this.iconButtonWindowMax.UseVisualStyleBackColor = false;
            this.iconButtonWindowMax.Click += new System.EventHandler(this.iconButtonWindowMax_Click);
            // 
            // iconButtonWindowClose
            // 
            this.iconButtonWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonWindowClose.FlatAppearance.BorderSize = 0;
            this.iconButtonWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWindowClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonWindowClose.IconColor = System.Drawing.Color.White;
            this.iconButtonWindowClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonWindowClose.IconSize = 25;
            this.iconButtonWindowClose.Location = new System.Drawing.Point(1419, 0);
            this.iconButtonWindowClose.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.iconButtonWindowClose.Name = "iconButtonWindowClose";
            this.iconButtonWindowClose.Size = new System.Drawing.Size(60, 46);
            this.iconButtonWindowClose.TabIndex = 12;
            this.iconButtonWindowClose.UseVisualStyleBackColor = false;
            this.iconButtonWindowClose.Click += new System.EventHandler(this.iconButtonWindowClose_Click);
            // 
            // BorderlessMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 879);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelTopBar);
            this.Name = "BorderlessMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton iconButtonWindowMin;
        private FontAwesome.Sharp.IconButton iconButtonWindowMax;
        private FontAwesome.Sharp.IconButton iconButtonWindowClose;
        private System.Windows.Forms.Panel panelTopBar;
    }
}

