
namespace BaseForm.Modules
{
    partial class formEditForm
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
            this.components = new System.ComponentModel.Container();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.iconButtonTitle = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonColor = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.iconButtonGeneral = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonSaveClose = new FontAwesome.Sharp.IconButton();
            this.panelTopBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelTopBar.Controls.Add(this.iconButtonTitle);
            this.panelTopBar.Controls.Add(this.iconButtonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1084, 46);
            this.panelTopBar.TabIndex = 19;
            this.panelTopBar.Tag = "panelControlBar";
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlBar_MouseDown);
            // 
            // iconButtonTitle
            // 
            this.iconButtonTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTitle.FlatAppearance.BorderSize = 0;
            this.iconButtonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonTitle.ForeColor = System.Drawing.Color.White;
            this.iconButtonTitle.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.iconButtonTitle.IconColor = System.Drawing.Color.White;
            this.iconButtonTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTitle.IconSize = 30;
            this.iconButtonTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTitle.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTitle.Name = "iconButtonTitle";
            this.iconButtonTitle.Padding = new System.Windows.Forms.Padding(10, 4, 3, 4);
            this.iconButtonTitle.Size = new System.Drawing.Size(230, 46);
            this.iconButtonTitle.TabIndex = 15;
            this.iconButtonTitle.Tag = "icon";
            this.iconButtonTitle.Text = "Edit Form";
            this.iconButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTitle.UseVisualStyleBackColor = true;
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
            this.iconButtonClose.Location = new System.Drawing.Point(1024, 0);
            this.iconButtonClose.Margin = new System.Windows.Forms.Padding(4, 16, 4, 8);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(60, 46);
            this.iconButtonClose.TabIndex = 14;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(230, 46);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(854, 715);
            this.panelControl.TabIndex = 22;
            this.panelControl.Tag = "panelControl";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.iconButtonColor);
            this.panelMenu.Controls.Add(this.iconButtonMenu);
            this.panelMenu.Controls.Add(this.iconButtonGeneral);
            this.panelMenu.Controls.Add(this.iconButtonSave);
            this.panelMenu.Controls.Add(this.iconButtonSaveClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(230, 715);
            this.panelMenu.TabIndex = 22;
            // 
            // iconButtonColor
            // 
            this.iconButtonColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonColor.FlatAppearance.BorderSize = 0;
            this.iconButtonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColor.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonColor.ForeColor = System.Drawing.Color.White;
            this.iconButtonColor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonColor.IconColor = System.Drawing.Color.White;
            this.iconButtonColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColor.IconSize = 30;
            this.iconButtonColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonColor.Location = new System.Drawing.Point(0, 108);
            this.iconButtonColor.Name = "iconButtonColor";
            this.iconButtonColor.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.iconButtonColor.Size = new System.Drawing.Size(230, 54);
            this.iconButtonColor.TabIndex = 11;
            this.iconButtonColor.Tag = "ThemeColors";
            this.iconButtonColor.Text = "ThemeColors";
            this.iconButtonColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonColor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonColor.UseVisualStyleBackColor = true;
            this.iconButtonColor.Click += new System.EventHandler(this.iconButtonColor_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonMenu.ForeColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.IconSize = 30;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 54);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.iconButtonMenu.Size = new System.Drawing.Size(230, 54);
            this.iconButtonMenu.TabIndex = 19;
            this.iconButtonMenu.Tag = "Design";
            this.iconButtonMenu.Text = "Design";
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // iconButtonGeneral
            // 
            this.iconButtonGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGeneral.FlatAppearance.BorderSize = 0;
            this.iconButtonGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGeneral.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonGeneral.ForeColor = System.Drawing.Color.White;
            this.iconButtonGeneral.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonGeneral.IconColor = System.Drawing.Color.White;
            this.iconButtonGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGeneral.IconSize = 30;
            this.iconButtonGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGeneral.Location = new System.Drawing.Point(0, 0);
            this.iconButtonGeneral.Name = "iconButtonGeneral";
            this.iconButtonGeneral.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.iconButtonGeneral.Size = new System.Drawing.Size(230, 54);
            this.iconButtonGeneral.TabIndex = 20;
            this.iconButtonGeneral.Tag = "General";
            this.iconButtonGeneral.Text = "General";
            this.iconButtonGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonGeneral.UseVisualStyleBackColor = true;
            this.iconButtonGeneral.Click += new System.EventHandler(this.iconButtonGeneral_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSave.FlatAppearance.BorderSize = 0;
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.White;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(0, 592);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonSave.Size = new System.Drawing.Size(230, 54);
            this.iconButtonSave.TabIndex = 18;
            this.iconButtonSave.Tag = "Save Form";
            this.iconButtonSave.Text = "Save Form";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // iconButtonSaveClose
            // 
            this.iconButtonSaveClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSaveClose.FlatAppearance.BorderSize = 0;
            this.iconButtonSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveClose.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonSaveClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonSaveClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonSaveClose.IconColor = System.Drawing.Color.White;
            this.iconButtonSaveClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveClose.IconSize = 30;
            this.iconButtonSaveClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSaveClose.Location = new System.Drawing.Point(0, 646);
            this.iconButtonSaveClose.Name = "iconButtonSaveClose";
            this.iconButtonSaveClose.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonSaveClose.Size = new System.Drawing.Size(230, 54);
            this.iconButtonSaveClose.TabIndex = 17;
            this.iconButtonSaveClose.Tag = "Close";
            this.iconButtonSaveClose.Text = "Close";
            this.iconButtonSaveClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSaveClose.UseVisualStyleBackColor = true;
            this.iconButtonSaveClose.Click += new System.EventHandler(this.iconButtonSaveClose_Click);
            // 
            // formEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formEditForm";
            this.Load += new System.EventHandler(this.formEditForm_Load);
            this.Resize += new System.EventHandler(this.formEditForm_Resize);
            this.panelTopBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelTopBar;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton iconButtonTitle;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonColor;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonSaveClose;
        private FontAwesome.Sharp.IconButton iconButtonGeneral;
    }
}