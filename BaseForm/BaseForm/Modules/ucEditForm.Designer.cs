
namespace BaseForm.Modules
{
    partial class ucEditForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonDataLog = new FontAwesome.Sharp.IconButton();
            this.iconButtonMeasure = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelMenu, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1129, 695);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(1123, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Edit Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.iconButtonSave);
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonDataLog);
            this.panelMenu.Controls.Add(this.iconButtonMeasure);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(3, 54);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(230, 637);
            this.panelMenu.TabIndex = 7;
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSave.FlatAppearance.BorderSize = 0;
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.White;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(0, 568);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonSave.Size = new System.Drawing.Size(230, 54);
            this.iconButtonSave.TabIndex = 15;
            this.iconButtonSave.Tag = "Save";
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = true;
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
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 162);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonSetting.Size = new System.Drawing.Size(230, 54);
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
            this.iconButtonDataLog.Location = new System.Drawing.Point(0, 108);
            this.iconButtonDataLog.Name = "iconButtonDataLog";
            this.iconButtonDataLog.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonDataLog.Size = new System.Drawing.Size(230, 54);
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
            this.iconButtonMeasure.Location = new System.Drawing.Point(0, 54);
            this.iconButtonMeasure.Name = "iconButtonMeasure";
            this.iconButtonMeasure.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonMeasure.Size = new System.Drawing.Size(230, 54);
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
            this.iconButtonHome.Location = new System.Drawing.Point(0, 0);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.iconButtonHome.Size = new System.Drawing.Size(230, 54);
            this.iconButtonHome.TabIndex = 11;
            this.iconButtonHome.Tag = "Home";
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            // 
            // ucEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucEditForm";
            this.Size = new System.Drawing.Size(1129, 695);
            this.Load += new System.EventHandler(this.ucEditForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonDataLog;
        private FontAwesome.Sharp.IconButton iconButtonMeasure;
        private FontAwesome.Sharp.IconButton iconButtonHome;
    }
}
