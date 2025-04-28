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

        public static ThemeColors KaisStyle => new ThemeColors
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


        public static ThemeColors ModernBlue => new ThemeColors
        {
            BackColor = Color.FromArgb(240, 248, 255), // AliceBlue
            TopPanelColor = Color.FromArgb(100, 149, 237), // CornflowerBlue
            MenuPanelColor = Color.FromArgb(70, 130, 180), // SteelBlue
            BorderColor = Color.FromArgb(25, 25, 112), // MidnightBlue
            PointColor = Color.FromArgb(30, 144, 255), // DodgerBlue
            FontColor = Color.Black,
            IconColor = Color.Black,
            ButtonColor = Color.FromArgb(100, 149, 237),
            Image = Properties.Resources.kais_basic
        };

        public static ThemeColors CozyOrange => new ThemeColors
        {
            BackColor = Color.FromArgb(255, 248, 220), // Cornsilk
            TopPanelColor = Color.FromArgb(255, 165, 0), // Orange
            MenuPanelColor = Color.FromArgb(255, 200, 120), // 연한 오렌지
            BorderColor = Color.FromArgb(255, 140, 0), // DarkOrange
            PointColor = Color.FromArgb(255, 99, 71), // Tomato
            FontColor = Color.Black,
            IconColor = Color.Black,
            ButtonColor = Color.FromArgb(255, 165, 0),
            Image = Properties.Resources.kais_basic
        };

        public static ThemeColors ControlStyle => new ThemeColors
        {
            BackColor = SystemColors.Control, // Windows 기본 컨트롤 배경
            TopPanelColor = SystemColors.ControlDark, // 약간 어두운
            MenuPanelColor = SystemColors.ControlLight, // 약간 밝은
            BorderColor = SystemColors.ActiveBorder, // 시스템 활성 테두리
            PointColor = Color.DeepSkyBlue, // 확실하게 튀는 포인트
            FontColor = SystemColors.ControlText, // 일반 글자색
            IconColor = SystemColors.ControlText,
            ButtonColor = SystemColors.ControlDarkDark,
            Image = Properties.Resources.kais_basic
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

    }
}
