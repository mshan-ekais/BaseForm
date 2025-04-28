
namespace BaseForm.SampleCode
{
    partial class formSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPopupTopBar = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonOK = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonTitle = new FontAwesome.Sharp.IconButton();
            this.panelPopupTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPopupTopBar
            // 
            this.panelPopupTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelPopupTopBar.Controls.Add(this.iconButtonTitle);
            this.panelPopupTopBar.Controls.Add(this.iconButtonClose);
            this.panelPopupTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPopupTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelPopupTopBar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelPopupTopBar.Name = "panelPopupTopBar";
            this.panelPopupTopBar.Size = new System.Drawing.Size(584, 46);
            this.panelPopupTopBar.TabIndex = 18;
            this.panelPopupTopBar.Tag = "panelControlBar";
            this.panelPopupTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBar_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 25;
            this.iconButtonClose.Location = new System.Drawing.Point(524, 0);
            this.iconButtonClose.Margin = new System.Windows.Forms.Padding(4, 11, 4, 6);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(60, 46);
            this.iconButtonClose.TabIndex = 14;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonOK
            // 
            this.iconButtonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButtonOK.FlatAppearance.BorderSize = 0;
            this.iconButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOK.IconColor = System.Drawing.Color.Black;
            this.iconButtonOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOK.Location = new System.Drawing.Point(417, 222);
            this.iconButtonOK.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.iconButtonOK.Name = "iconButtonOK";
            this.iconButtonOK.Size = new System.Drawing.Size(155, 58);
            this.iconButtonOK.TabIndex = 17;
            this.iconButtonOK.Tag = "button";
            this.iconButtonOK.Text = "OK";
            this.iconButtonOK.UseVisualStyleBackColor = false;
            this.iconButtonOK.Click += new System.EventHandler(this.iconButtonOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 295);
            this.panel1.TabIndex = 19;
            // 
            // iconButtonTitle
            // 
            this.iconButtonTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTitle.FlatAppearance.BorderSize = 0;
            this.iconButtonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonTitle.ForeColor = System.Drawing.Color.White;
            this.iconButtonTitle.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonTitle.IconColor = System.Drawing.Color.White;
            this.iconButtonTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTitle.IconSize = 30;
            this.iconButtonTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTitle.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTitle.Name = "iconButtonTitle";
            this.iconButtonTitle.Padding = new System.Windows.Forms.Padding(10, 4, 3, 4);
            this.iconButtonTitle.Size = new System.Drawing.Size(230, 46);
            this.iconButtonTitle.TabIndex = 16;
            this.iconButtonTitle.Tag = "icon";
            this.iconButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTitle.UseVisualStyleBackColor = true;
            // 
            // formSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPopupTopBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formSample";
            this.Resize += new System.EventHandler(this.formSample_Resize);
            this.panelPopupTopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelPopupTopBar;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        public FontAwesome.Sharp.IconButton iconButtonOK;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonTitle;
    }
}