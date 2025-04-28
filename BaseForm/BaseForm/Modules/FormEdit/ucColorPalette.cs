using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BaseForm.Modules.FormEdit
{
    public partial class ucColorPalatte : UserControl
    {
        public ucColorPalatte()
        {
            this.HorizontalScroll.Visible = false;
            this.VerticalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.VerticalScroll.Maximum = 0;

            InitializeThemes();
            InitializeUI();
        }

        public event Action<ThemeColors> ThemeChanged;
        private readonly Dictionary<string, ThemeColors> themeMap = new Dictionary<string, ThemeColors>();
        private readonly Dictionary<string, Color[]> themePreviewMap = new Dictionary<string, Color[]>();
        private Dictionary<RadioButton, ThemeColors> radioButtonThemeMap = new Dictionary<RadioButton, ThemeColors>();

        private Dictionary<string, ThemeColors> GetAllThemes()
        {
            var themes = new Dictionary<string, ThemeColors>();
            var properties = typeof(ThemeColors).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (var prop in properties)
            {
                if (prop.PropertyType == typeof(ThemeColors))
                {
                    string name = prop.Name;
                    ThemeColors value = (ThemeColors)prop.GetValue(null);
                    themes[name] = value;
                }
            }
            return themes;
        }

        public ThemeColors _currentTheme;
        public ThemeColors ThemeColor
        {
            get => _currentTheme;
            set
            {
                _currentTheme = value;
                foreach (var kvp in radioButtonThemeMap)
                {
                    var radio = kvp.Key;
                    var theme = kvp.Value;

                    if (IsSameTheme(theme, _currentTheme))
                    {
                        radio.Checked = true;
                        break;
                    }
                }
            }
        }

        private void InitializeThemes()
        {
            themeMap.Clear();
            themePreviewMap.Clear();

            var themes = GetAllThemes();

            foreach (var kvp in themes)
            {
                var theme = kvp.Value;
                themeMap[kvp.Key] = theme;

                themePreviewMap[kvp.Key] = new Color[]
                {
                    theme.TopPanelColor,
                    theme.MenuPanelColor,
                    theme.BackColor,
                    theme.PointColor,
                    theme.FontColor,
                    theme.ButtonColor,
                    theme.BorderColor
                };
            }
        }

        private void InitializeUI()
        {
            int margin = 10;
            int y = margin;

            foreach (var themeName in themeMap.Keys)
            {
                var radio = new RadioButton()
                {
                    Text = themeName,
                    Location = new Point(margin, y),
                    AutoSize = true,
                    Tag = themeMap[themeName]
                };
                radio.CheckedChanged += (s, e) =>
                {
                    var btn = s as RadioButton;
                    if (btn.Checked)
                    {
                        ThemeColor = (ThemeColors)btn.Tag;
                        ThemeChanged?.Invoke(ThemeColor);
                    }
                };

                var preview = CreateColorPreview(themePreviewMap[themeName]);
                preview.Location = new Point(margin + 25, y + 25);

                this.Controls.Add(radio);
                this.Controls.Add(preview);

                radioButtonThemeMap[radio] = (ThemeColors)radio.Tag;
                y += preview.Height + 45;
            }
        }

        private bool IsSameTheme(ThemeColors a, ThemeColors b)
        {
            return a.BackColor == b.BackColor &&
                   a.TopPanelColor == b.TopPanelColor &&
                   a.MenuPanelColor == b.MenuPanelColor &&
                   a.FontColor == b.FontColor;
        }

        private FlowLayoutPanel CreateColorPreview(Color[] colors)
        {
            var panel = new FlowLayoutPanel()
            {
                Size = new Size(500, 45),
                FlowDirection = FlowDirection.LeftToRight,
                BackColor = Color.Transparent
            };

            foreach (var color in colors)
            {
                panel.Controls.Add(new Panel()
                {
                    BackColor = color,
                    Size = new Size(40, 40),
                    Margin = new Padding(4),
                    BorderStyle = BorderStyle.FixedSingle
                });
            }
            return panel;
        }

    }
}
