
namespace BaseForm.Modules.FormEdit
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButtonIEditForm = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonDataLog = new FontAwesome.Sharp.IconButton();
            this.iconButtonMeasure = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.panelLeft);
            this.panelMenu.Controls.Add(this.iconButtonIEditForm);
            this.panelMenu.Controls.Add(this.iconButtonClose);
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonDataLog);
            this.panelMenu.Controls.Add(this.iconButtonMeasure);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Controls.Add(this.iconButtonMenu);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(233, 864);
            this.panelMenu.TabIndex = 7;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 173);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 54);
            this.panelLeft.TabIndex = 0;
            // 
            // iconButtonIEditForm
            // 
            this.iconButtonIEditForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonIEditForm.FlatAppearance.BorderSize = 0;
            this.iconButtonIEditForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIEditForm.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonIEditForm.ForeColor = System.Drawing.Color.White;
            this.iconButtonIEditForm.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.iconButtonIEditForm.IconColor = System.Drawing.Color.White;
            this.iconButtonIEditForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIEditForm.IconSize = 30;
            this.iconButtonIEditForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonIEditForm.Location = new System.Drawing.Point(0, 741);
            this.iconButtonIEditForm.Name = "iconButtonIEditForm";
            this.iconButtonIEditForm.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonIEditForm.Size = new System.Drawing.Size(233, 54);
            this.iconButtonIEditForm.TabIndex = 16;
            this.iconButtonIEditForm.Tag = "Edit Form";
            this.iconButtonIEditForm.Text = "Edit Form";
            this.iconButtonIEditForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonIEditForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonIEditForm.UseVisualStyleBackColor = true;
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
            this.iconButtonClose.Location = new System.Drawing.Point(0, 795);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonClose.Size = new System.Drawing.Size(233, 54);
            this.iconButtonClose.TabIndex = 15;
            this.iconButtonClose.Tag = "Close";
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonSetting.ForeColor = System.Drawing.Color.White;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonSetting.IconColor = System.Drawing.Color.White;
            this.iconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSetting.IconSize = 30;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 335);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonSetting.Size = new System.Drawing.Size(233, 54);
            this.iconButtonSetting.TabIndex = 14;
            this.iconButtonSetting.Tag = "Setting";
            this.iconButtonSetting.Text = "Setting";
            this.iconButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            // 
            // iconButtonDataLog
            // 
            this.iconButtonDataLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDataLog.FlatAppearance.BorderSize = 0;
            this.iconButtonDataLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDataLog.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonDataLog.ForeColor = System.Drawing.Color.White;
            this.iconButtonDataLog.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconButtonDataLog.IconColor = System.Drawing.Color.White;
            this.iconButtonDataLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDataLog.IconSize = 30;
            this.iconButtonDataLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDataLog.Location = new System.Drawing.Point(0, 281);
            this.iconButtonDataLog.Name = "iconButtonDataLog";
            this.iconButtonDataLog.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonDataLog.Size = new System.Drawing.Size(233, 54);
            this.iconButtonDataLog.TabIndex = 13;
            this.iconButtonDataLog.Tag = "Data Log";
            this.iconButtonDataLog.Text = "Data Log";
            this.iconButtonDataLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDataLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDataLog.UseVisualStyleBackColor = true;
            // 
            // iconButtonMeasure
            // 
            this.iconButtonMeasure.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMeasure.FlatAppearance.BorderSize = 0;
            this.iconButtonMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMeasure.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonMeasure.ForeColor = System.Drawing.Color.White;
            this.iconButtonMeasure.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButtonMeasure.IconColor = System.Drawing.Color.White;
            this.iconButtonMeasure.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMeasure.IconSize = 30;
            this.iconButtonMeasure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeasure.Location = new System.Drawing.Point(0, 227);
            this.iconButtonMeasure.Name = "iconButtonMeasure";
            this.iconButtonMeasure.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonMeasure.Size = new System.Drawing.Size(233, 54);
            this.iconButtonMeasure.TabIndex = 12;
            this.iconButtonMeasure.Tag = "Measurement";
            this.iconButtonMeasure.Text = "Measurement";
            this.iconButtonMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMeasure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMeasure.UseVisualStyleBackColor = true;
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
            this.iconButtonHome.Location = new System.Drawing.Point(0, 173);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonHome.Size = new System.Drawing.Size(233, 54);
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
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 113);
            this.iconButtonMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.iconButtonMenu.Size = new System.Drawing.Size(233, 60);
            this.iconButtonMenu.TabIndex = 10;
            this.iconButtonMenu.Tag = "menu";
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 113);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Padding = new System.Windows.Forms.Padding(30);
            this.pictureBoxLogo.Size = new System.Drawing.Size(233, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ucMenuVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Name = "ucMenuVertical";
            this.Size = new System.Drawing.Size(233, 864);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLeft;
        private FontAwesome.Sharp.IconButton iconButtonIEditForm;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonDataLog;
        private FontAwesome.Sharp.IconButton iconButtonMeasure;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
