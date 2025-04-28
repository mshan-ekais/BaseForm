
namespace BaseForm.Modules
{
    partial class formPopup
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
            this.panelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pannelControl = new System.Windows.Forms.TableLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.iconButtonOK = new FontAwesome.Sharp.IconButton();
            this.iconButtonNO = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonTitle = new FontAwesome.Sharp.IconButton();
            this.panelPopupTopBar.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.pannelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPopupTopBar
            // 
            this.panelPopupTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelPopupTopBar.Controls.Add(this.iconButtonClose);
            this.panelPopupTopBar.Controls.Add(this.iconButtonTitle);
            this.panelPopupTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPopupTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelPopupTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPopupTopBar.Name = "panelPopupTopBar";
            this.panelPopupTopBar.Size = new System.Drawing.Size(461, 46);
            this.panelPopupTopBar.TabIndex = 16;
            this.panelPopupTopBar.Tag = "panelControlBar";
            this.panelPopupTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBar_MouseDown);
            // 
            // panelBottom
            // 
            this.panelBottom.ColumnCount = 5;
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.268118F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59782F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.268118F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59782F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.268118F));
            this.panelBottom.Controls.Add(this.iconButtonOK, 3, 0);
            this.panelBottom.Controls.Add(this.iconButtonNO, 1, 0);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 222);
            this.panelBottom.MinimumSize = new System.Drawing.Size(0, 70);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.panelBottom.RowCount = 1;
            this.panelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBottom.Size = new System.Drawing.Size(461, 70);
            this.panelBottom.TabIndex = 18;
            // 
            // pannelControl
            // 
            this.pannelControl.ColumnCount = 1;
            this.pannelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelControl.Controls.Add(this.labelText, 0, 0);
            this.pannelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelControl.Location = new System.Drawing.Point(0, 46);
            this.pannelControl.Name = "pannelControl";
            this.pannelControl.RowCount = 1;
            this.pannelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelControl.Size = new System.Drawing.Size(461, 176);
            this.pannelControl.TabIndex = 20;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelText.Location = new System.Drawing.Point(3, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(455, 176);
            this.labelText.TabIndex = 20;
            this.labelText.Text = "msg";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonOK
            // 
            this.iconButtonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButtonOK.FlatAppearance.BorderSize = 0;
            this.iconButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOK.IconColor = System.Drawing.Color.Black;
            this.iconButtonOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOK.Location = new System.Drawing.Point(252, 9);
            this.iconButtonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonOK.Name = "iconButtonOK";
            this.iconButtonOK.Size = new System.Drawing.Size(155, 41);
            this.iconButtonOK.TabIndex = 2;
            this.iconButtonOK.Tag = "button";
            this.iconButtonOK.Text = "OK";
            this.iconButtonOK.UseVisualStyleBackColor = false;
            this.iconButtonOK.Click += new System.EventHandler(this.iconButtonOK_Click);
            // 
            // iconButtonNO
            // 
            this.iconButtonNO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButtonNO.FlatAppearance.BorderSize = 0;
            this.iconButtonNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNO.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonNO.IconColor = System.Drawing.Color.Black;
            this.iconButtonNO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNO.Location = new System.Drawing.Point(41, 9);
            this.iconButtonNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonNO.Name = "iconButtonNO";
            this.iconButtonNO.Size = new System.Drawing.Size(155, 41);
            this.iconButtonNO.TabIndex = 1;
            this.iconButtonNO.Tag = "button";
            this.iconButtonNO.Text = "NO";
            this.iconButtonNO.UseVisualStyleBackColor = false;
            this.iconButtonNO.Click += new System.EventHandler(this.iconButtonNo_Click);
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
            this.iconButtonClose.Location = new System.Drawing.Point(401, 0);
            this.iconButtonClose.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(60, 46);
            this.iconButtonClose.TabIndex = 14;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonTitle
            // 
            this.iconButtonTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTitle.Enabled = false;
            this.iconButtonTitle.FlatAppearance.BorderSize = 0;
            this.iconButtonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTitle.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconButtonTitle.IconColor = System.Drawing.Color.White;
            this.iconButtonTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTitle.IconSize = 40;
            this.iconButtonTitle.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTitle.Name = "iconButtonTitle";
            this.iconButtonTitle.Size = new System.Drawing.Size(80, 46);
            this.iconButtonTitle.TabIndex = 13;
            this.iconButtonTitle.Tag = "icon";
            this.iconButtonTitle.UseVisualStyleBackColor = false;
            // 
            // formPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 292);
            this.Controls.Add(this.pannelControl);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelPopupTopBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.formPopup_Load);
            this.Resize += new System.EventHandler(this.formPopup_Resize);
            this.panelPopupTopBar.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.pannelControl.ResumeLayout(false);
            this.pannelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelPopupTopBar;
        public FontAwesome.Sharp.IconButton iconButtonNO;
        public FontAwesome.Sharp.IconButton iconButtonOK;
        public System.Windows.Forms.TableLayoutPanel panelBottom;
        public System.Windows.Forms.Label labelText;
        public System.Windows.Forms.TableLayoutPanel pannelControl;
        public FontAwesome.Sharp.IconButton iconButtonTitle;
        private FontAwesome.Sharp.IconButton iconButtonClose;
    }
}