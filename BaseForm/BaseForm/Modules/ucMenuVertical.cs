using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm.Modules
{
    public partial class ucMenuVertical : UserControl
    {
        public event Action<MenuButtonType> MenuButtonClicked;
        public event Action CollapseToggled;
        public Panel PanelLeft => panelLeft;

        public enum MenuButtonType
        {
            Home,
            Measure,
            DataLog,
            Setting,
            EditForm,
            Close
        }

        public ucMenuVertical()
        {
            InitializeComponent();
            panelPicture.Height = panelPicture.Width / 2;

            AttachEvents();
        }


        private void AttachEvents()
        {
            iconButtonMenu.Click += (s, e) => CollapseToggled?.Invoke();

            iconButtonHome.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Home);
            iconButtonMeasure.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Measure);
            iconButtonDataLog.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.DataLog);
            iconButtonSetting.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Setting);
            iconButtonIEditForm.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.EditForm);
            iconButtonClose.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Close);
        }

        public IconButton GetButton(MenuButtonType buttonType)
        {
            switch (buttonType)
            {
                case MenuButtonType.Home:
                    return iconButtonHome;
                case MenuButtonType.Measure:
                    return iconButtonMeasure;
                case MenuButtonType.DataLog:
                    return iconButtonDataLog;
                case MenuButtonType.Setting:
                    return iconButtonSetting;
                case MenuButtonType.EditForm:
                    return iconButtonIEditForm;
                case MenuButtonType.Close:
                    return iconButtonClose;
                default:
                    throw new ArgumentOutOfRangeException(nameof(buttonType), buttonType, null);
            }
        }

        //public void CollapseMenu()
        //{
        //    if (this.Width > 200)  //Collase menu
        //    {
        //        this.Width = 100;
        //        pictureBoxLogo.Visible = false;
        //        iconButtonMenu.Dock = DockStyle.Top;

        //        foreach (Button menuButton in this.Controls.OfType<Button>())
        //        {
        //            menuButton.Text = "";
        //            menuButton.ImageAlign = ContentAlignment.MiddleCenter;
        //            menuButton.Padding = new Padding(0);
        //        }
        //    }
        //    else
        //    {   //Expand menu
        //        this.Width = 230;
        //        pictureBoxLogo.Visible = true;
        //        iconButtonMenu.Dock = DockStyle.Top;

        //        foreach (Button menuButton in this.Controls.OfType<Button>())
        //        {
        //            if (menuButton.Tag.ToString() == "menu")
        //            {
        //                menuButton.ImageAlign = ContentAlignment.MiddleRight;
        //                menuButton.Padding = new Padding(30, 30, 30, 30);
        //            }
        //            else
        //            {
        //                menuButton.Text = menuButton.Tag.ToString();
        //                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
        //                menuButton.Padding = new Padding(30, 10, 0, 10);
        //            }
        //        }
        //    }
        //}
    }
}
