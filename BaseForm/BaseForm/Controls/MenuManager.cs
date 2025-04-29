using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseForm.Controls
{
    public class MenuManager
    {
        public enum MenuButtonType
        {
            Home,
            Measure,
            DataLog,
            Setting,
            EditForm,
            Close
        }

        public class MenuItem
        {
            public string Key { get; set; }
            public string Name { get; set; }
            public IconChar Icon { get; set; }
            public MenuButtonType ButtonType { get; set; }
            
        }


        public static List<MenuItem> MenuItems = new List<MenuItem>
        {
            // Button
            //new MenuItem {
            //    Key = "Home",
            //    Name = "Home",
            //    Icon = IconChar.Home,
            //    ButtonType = MenuButtonType.Home
            //},
            new MenuItem {
                Key = "Measurement",
                Name = "Measurement",
                Icon = IconChar.Camera,
                ButtonType = MenuButtonType.Measure
            },
            new MenuItem {
                Key = "Data Log",
                Name = "Data Log",
                Icon = IconChar.ChartBar,
                ButtonType = MenuButtonType.DataLog
            },
            new MenuItem {
                Key = "Setting",
                Name = "Setting",
                Icon = IconChar.Cogs,
                ButtonType = MenuButtonType.Setting
            },
            //new MenuItem {
            //    Key = "Edit Form",
            //    Name = "Edit Form",
            //    Icon = IconChar.PaintBrush,
            //    ButtonType = MenuButtonType.EditForm
            //},
            //new MenuItem {
            //    Key = "Close",
            //    Name = "Close",
            //    Icon = IconChar.SignOutAlt,
            //    ButtonType = MenuButtonType.Close
            //}
        };
    }
}
