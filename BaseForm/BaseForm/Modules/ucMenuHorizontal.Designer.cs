
namespace BaseForm.Modules
{
    partial class ucMenuHorizontal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenuHorizontal));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panelClose = new System.Windows.Forms.Panel();
            this.iconButtonEditForm = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.panelMenuAdd = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panelBar);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(204, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(25, 20, 25, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Padding = new System.Windows.Forms.Padding(25, 20, 25, 10);
            this.pictureBoxLogo.Size = new System.Drawing.Size(204, 85);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.iconButtonHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHome.Location = new System.Drawing.Point(204, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(110, 85);
            this.panelHome.TabIndex = 1;
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonHome.ForeColor = System.Drawing.Color.White;
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.White;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 30;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 0);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonHome.Size = new System.Drawing.Size(110, 85);
            this.iconButtonHome.TabIndex = 12;
            this.iconButtonHome.Tag = "Home";
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            // 
            // panelClose
            // 
            this.panelClose.AutoSize = true;
            this.panelClose.Controls.Add(this.iconButtonEditForm);
            this.panelClose.Controls.Add(this.iconButtonClose);
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClose.Location = new System.Drawing.Point(914, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(220, 85);
            this.panelClose.TabIndex = 2;
            // 
            // iconButtonEditForm
            // 
            this.iconButtonEditForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonEditForm.FlatAppearance.BorderSize = 0;
            this.iconButtonEditForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditForm.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonEditForm.ForeColor = System.Drawing.Color.White;
            this.iconButtonEditForm.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.iconButtonEditForm.IconColor = System.Drawing.Color.White;
            this.iconButtonEditForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditForm.IconSize = 30;
            this.iconButtonEditForm.Location = new System.Drawing.Point(0, 0);
            this.iconButtonEditForm.Name = "iconButtonEditForm";
            this.iconButtonEditForm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonEditForm.Size = new System.Drawing.Size(110, 85);
            this.iconButtonEditForm.TabIndex = 14;
            this.iconButtonEditForm.Tag = "Edit Form";
            this.iconButtonEditForm.Text = "Edit Form";
            this.iconButtonEditForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonEditForm.UseVisualStyleBackColor = true;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.Location = new System.Drawing.Point(110, 0);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButtonClose.Size = new System.Drawing.Size(110, 85);
            this.iconButtonClose.TabIndex = 13;
            this.iconButtonClose.Tag = "Close";
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // panelMenuAdd
            // 
            this.panelMenuAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuAdd.Location = new System.Drawing.Point(314, 0);
            this.panelMenuAdd.Name = "panelMenuAdd";
            this.panelMenuAdd.Size = new System.Drawing.Size(600, 85);
            this.panelMenuAdd.TabIndex = 3;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.panelBar.Location = new System.Drawing.Point(0, 72);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(110, 13);
            this.panelBar.TabIndex = 15;
            // 
            // ucMenuHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuAdd);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelLogo);
            this.Name = "ucMenuHorizontal";
            this.Size = new System.Drawing.Size(1134, 85);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelClose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHome;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMenuAdd;
        public System.Windows.Forms.Panel panelBar;
        public FontAwesome.Sharp.IconButton iconButtonEditForm;
        public FontAwesome.Sharp.IconButton iconButtonClose;
    }
}
