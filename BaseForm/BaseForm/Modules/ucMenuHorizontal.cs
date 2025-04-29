using BaseForm.Controls;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaseForm.Controls.MenuManager;

namespace BaseForm.Modules
{
    public partial class ucMenuHorizontal : UserControl
    {
        public event Action<MenuButtonType> MenuButtonClicked;
        public event Action CollapseToggled;
        public Panel PanelBar => panelBar;
        public Dictionary<MenuButtonType, IconButton> _buttonMap = new Dictionary<MenuButtonType, IconButton>();

        public ucMenuHorizontal()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            this.Dock = DockStyle.Top;
            this.Height = 85;
            

            foreach (var item in MenuManager.MenuItems)
            {
                var button = CreateMenuButton(item);
                this.panelMenuAdd.Controls.Add(button);
                button.BringToFront();
            }

            this.Controls.Add(PanelBar);
            PanelBar.BringToFront();
            //iconButtonMenu.Click += (s, e) => CollapseToggled?.Invoke();
            iconButtonHome.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Home);
            iconButtonEditForm.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.EditForm);
            iconButtonClose.Click += (s, e) => MenuButtonClicked?.Invoke(MenuButtonType.Close);

            _buttonMap[MenuButtonType.Home] = iconButtonHome;
            _buttonMap[MenuButtonType.EditForm] = iconButtonEditForm;
            _buttonMap[MenuButtonType.Close] = iconButtonClose;
        }



        private IconButton CloneButton(IconButton source)
        {
            IconButton clone = new IconButton();

            // 기본 속성 복사
            clone.Size = source.Size;
            clone.Width = source.Width;
            clone.Height = source.Height;
            clone.Font = source.Font;
            clone.TextAlign = source.TextAlign;
            clone.ImageAlign = source.ImageAlign;
            clone.TextImageRelation = source.TextImageRelation;
            clone.FlatStyle = source.FlatStyle;
            clone.FlatAppearance.BorderSize = source.FlatAppearance.BorderSize;
            clone.FlatAppearance.BorderColor = source.FlatAppearance.BorderColor;
            clone.Dock = source.Dock;
            clone.Padding = source.Padding;
            clone.Margin = source.Margin;

            clone.IconColor = source.IconColor;
            clone.IconFont = source.IconFont;
            clone.IconSize = source.IconSize;

            return clone;
        }

        private IconButton CreateMenuButton(MenuManager.MenuItem item)
        {
            IconButton button = CloneButton(iconButtonHome);
            button.Text = item.Name;
            button.IconChar = item.Icon;
            button.Tag = item.Key;
            button.Dock = DockStyle.Left;

            _buttonMap[item.ButtonType] = button;

            button.Click += (s, e) => MenuButtonClicked?.Invoke(item.ButtonType);
            return button;
        }


        public IconButton GetButton(MenuButtonType buttonType)
        {
            if (_buttonMap.TryGetValue(buttonType, out var button))
            {
                return button;
            }
            throw new ArgumentOutOfRangeException(nameof(buttonType), buttonType, null);
        }
    }
}
