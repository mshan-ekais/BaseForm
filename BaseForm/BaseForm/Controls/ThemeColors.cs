using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseForm.Modules
{

    public struct ThemeColors
    {
        public Color BackColor { get; set; }
        public Color TopPanelColor { get; set; }
        public Color MenuPanelColor { get; set; }
        public Color BorderColor { get; set; }
        public Color PointColor { get; set; }
        public Color FontColor { get; set; }
        public Color IconColor { get; set; }
        public Color ButtonColor { get; set; }
        public Image Image { get; set; }

        public static ThemeColors Dark => new ThemeColors
        {
            BackColor = Color.FromArgb(48, 48, 48),
            TopPanelColor = Color.FromArgb(32, 32, 32),
            MenuPanelColor = Color.FromArgb(32, 32, 32),
            BorderColor = Color.White,
            PointColor = Color.FromArgb(43, 144, 217),
            FontColor = Color.White,
            IconColor = Color.White,
            ButtonColor = Color.FromArgb(43, 144, 217),
            Image = Properties.Resources.kais_white
        };

        public static ThemeColors Light => new ThemeColors
        {
            BackColor = Color.White,
            TopPanelColor = Color.Gainsboro,
            MenuPanelColor = Color.WhiteSmoke,
            BorderColor = Color.Black,
            PointColor = Color.FromArgb(30, 144, 255),
            FontColor = Color.Black,
            IconColor = Color.Black,
            ButtonColor = Color.FromArgb(30, 144, 255),
            Image = Properties.Resources.kais_basic
        };

        public static ThemeColors LovelyStyle => new ThemeColors
        {
            BackColor = Color.FromArgb(255, 240, 245), // 라이트 핑크
            TopPanelColor = Color.FromArgb(255, 182, 193), // 라이트 핑크2
            MenuPanelColor = Color.FromArgb(255, 228, 225), // 미스트로즈
            BorderColor = Color.DeepPink,
            PointColor = Color.HotPink,
            FontColor = Color.DarkRed,
            IconColor = Color.DeepPink,
            ButtonColor = Color.FromArgb(255, 182, 193),
            Image = Properties.Resources.kais_white
        };

        public static ThemeColors VisualStudio2019Style => new ThemeColors
        {
            BackColor = Color.FromArgb(37, 37, 38),
            TopPanelColor = Color.FromArgb(45, 45, 48),
            MenuPanelColor = Color.FromArgb(51, 51, 55),
            BorderColor = Color.DimGray,
            PointColor = Color.FromArgb(0, 122, 204),
            FontColor = Color.White,
            IconColor = Color.LightGray,
            ButtonColor = Color.FromArgb(63, 63, 70),
            Image = Properties.Resources.kais_white
        };

        public static ThemeColors BasicStyle => new ThemeColors
        {
            BackColor = Color.White,
            TopPanelColor = Color.LightGray,
            MenuPanelColor = Color.Gainsboro,
            BorderColor = Color.Black,
            PointColor = Color.FromArgb(255, 69, 58),
            FontColor = Color.Black,
            IconColor = Color.Black,
            ButtonColor = Color.LightGray,
            Image = Properties.Resources.kais_basic
        };

        public static ThemeColors GreenStyle => new ThemeColors
        {
            BackColor = Color.Honeydew,
            TopPanelColor = Color.DarkSeaGreen,
            MenuPanelColor = Color.MintCream,
            BorderColor = Color.DarkGreen,
            PointColor = Color.SeaGreen,
            FontColor = Color.DarkGreen,
            IconColor = Color.ForestGreen,
            ButtonColor = Color.MediumSeaGreen,
            Image = Properties.Resources.kais_black
        };

        public static ThemeColors NavyRedStyle => new ThemeColors
        {
            BackColor = Color.FromArgb(10, 25, 50),
            TopPanelColor = Color.FromArgb(15, 35, 65),
            MenuPanelColor = Color.FromArgb(20, 45, 80),
            BorderColor = Color.WhiteSmoke,
            PointColor = Color.FromArgb(255, 69, 58),
            FontColor = Color.White,
            IconColor = Color.White,
            ButtonColor = Color.FromArgb(60, 80, 120),
            Image = Properties.Resources.kais_white_red
        };
    }
}
