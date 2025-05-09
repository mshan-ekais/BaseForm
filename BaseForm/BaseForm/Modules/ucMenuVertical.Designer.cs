﻿
namespace BaseForm.Modules
{
    partial class ucMenuVertical
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenuVertical));
            this.panelBar = new System.Windows.Forms.Panel();
            this.iconButtonEditForm = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelMenuAdd = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.panelBar.Location = new System.Drawing.Point(0, 44);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(10, 54);
            this.panelBar.TabIndex = 0;
            // 
            // iconButtonEditForm
            // 
            this.iconButtonEditForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonEditForm.FlatAppearance.BorderSize = 0;
            this.iconButtonEditForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditForm.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonEditForm.ForeColor = System.Drawing.Color.White;
            this.iconButtonEditForm.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.iconButtonEditForm.IconColor = System.Drawing.Color.White;
            this.iconButtonEditForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditForm.IconSize = 30;
            this.iconButtonEditForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditForm.Location = new System.Drawing.Point(0, 0);
            this.iconButtonEditForm.Name = "iconButtonEditForm";
            this.iconButtonEditForm.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonEditForm.Size = new System.Drawing.Size(229, 54);
            this.iconButtonEditForm.TabIndex = 16;
            this.iconButtonEditForm.Tag = "Edit Form";
            this.iconButtonEditForm.Text = "Edit Form";
            this.iconButtonEditForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditForm.UseVisualStyleBackColor = true;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(0, 54);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonClose.Size = new System.Drawing.Size(229, 54);
            this.iconButtonClose.TabIndex = 15;
            this.iconButtonClose.Tag = "Close";
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonHome.ForeColor = System.Drawing.Color.White;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.White;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 30;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 60);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonHome.Size = new System.Drawing.Size(229, 54);
            this.iconButtonHome.TabIndex = 11;
            this.iconButtonHome.Tag = "Home";
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.IconSize = 30;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.iconButtonMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.iconButtonMenu.Size = new System.Drawing.Size(229, 60);
            this.iconButtonMenu.TabIndex = 10;
            this.iconButtonMenu.Tag = "menu";
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Padding = new System.Windows.Forms.Padding(30);
            this.pictureBoxLogo.Size = new System.Drawing.Size(229, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.pictureBoxLogo);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(229, 100);
            this.panelPicture.TabIndex = 17;
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.Controls.Add(this.iconButtonHome);
            this.panelHome.Controls.Add(this.iconButtonMenu);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 100);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(229, 114);
            this.panelHome.TabIndex = 18;
            // 
            // panelClose
            // 
            this.panelClose.AutoSize = true;
            this.panelClose.Controls.Add(this.iconButtonEditForm);
            this.panelClose.Controls.Add(this.iconButtonClose);
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelClose.Location = new System.Drawing.Point(0, 728);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(229, 108);
            this.panelClose.TabIndex = 19;
            // 
            // panelMenuAdd
            // 
            this.panelMenuAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuAdd.Location = new System.Drawing.Point(0, 214);
            this.panelMenuAdd.Name = "panelMenuAdd";
            this.panelMenuAdd.Size = new System.Drawing.Size(229, 514);
            this.panelMenuAdd.TabIndex = 20;
            // 
            // ucMenuVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuAdd);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelPicture);
            this.Name = "ucMenuVertical";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Size = new System.Drawing.Size(229, 851);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelClose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panelPicture;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public FontAwesome.Sharp.IconButton iconButtonMenu;
        public System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMenuAdd;
        public FontAwesome.Sharp.IconButton iconButtonEditForm;
        public FontAwesome.Sharp.IconButton iconButtonClose;
    }
}
