using BaseForm.Modules.FormEdit;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm.Modules
{
    public partial class formEditForm : Form
    {
        private Dictionary<string, UserControl> loadedModules = new Dictionary<string, UserControl>();
        public event Action<ThemeColors> ThemeChanged;
        private ThemeColors _currentTheme;
        private Color menuBackColor;
        private const int BorderSize = 2;

        public formEditForm()
        {
            InitializeComponent();
        }

        #region Theme 설정 및 헬퍼 메서드
        public ThemeColors ThemeColor
        {
            get => _currentTheme;
            set
            {
                _currentTheme = value;
                ApplyTheme(_currentTheme);
            }
        }

        public static Color LightenColor(Color color, float amount = 0.2f)
        {
            int r = (int)(color.R + (255 - color.R) * amount);
            int g = (int)(color.G + (255 - color.G) * amount);
            int b = (int)(color.B + (255 - color.B) * amount);
            return Color.FromArgb(color.A, r, g, b);
        }


        public static IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                yield return child;

                foreach (Control grandChild in GetAllControls(child))
                {
                    yield return grandChild;
                }
            }
        }

        private void ApplyTheme(ThemeColors theme)
        {
            this.BackColor = theme.BorderColor;
            this.panelTopBar.BackColor = theme.TopPanelColor;
            menuBackColor = LightenColor(theme.MenuPanelColor, 0.1f);
            this.panelMenu.BackColor = menuBackColor;

            foreach (var control in GetAllControls(this))
            {
                if (control is Panel pnl && pnl.Tag?.ToString() == "panelControl")
                    pnl.BackColor = LightenColor(theme.BackColor, 0.1f);

                if (control is IconButton btn)
                {
                    if (btn.Tag != null && btn.Tag.ToString() == "button")
                    {
                        btn.BackColor = theme.ButtonColor;
                    }
                    btn.IconColor = theme.IconColor;
                    btn.ForeColor = theme.FontColor;
                }

                control.ForeColor = theme.FontColor;
            }

            foreach (var control in GetAllControls(this.panelMenu))
            {
                if (control is IconButton btn)
                    btn.BackColor = menuBackColor;
            }


            if (panelControl.Controls.Count > 0)
            {
                var currentControl = panelControl.Controls[0];
                if (currentControl is ucThemeColors)
                    iconButtonColor.BackColor = _currentTheme.PointColor;
            }
        }

        #endregion

        #region Form Behavior

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParm, int lParm);

        private void panelControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void formEditForm_Load(object sender, EventArgs e)
        {
            _ = LoadModuleAsync("ucGeneral", () => new ucGeneral());
            iconButtonGeneral.BackColor = _currentTheme.PointColor;
        }
       

        private void formEditForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        int borderSize = 2;
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        #endregion


        #region 메뉴 버튼 클릭 처리

        private async void iconButtonGeneral_Click(object sender, EventArgs e)
        {
            await HandleMenuButtonClick(iconButtonGeneral, "ucGeneral", () => new ucGeneral());
        }

        private async void iconButtonColor_Click(object sender, EventArgs e)
        {
            await HandleMenuButtonClick(iconButtonColor, "ucThemeColors", () =>
            {
                var ucTheme = new ucThemeColors(_currentTheme);
                ucTheme.ThemeChanged += theme =>
                {
                    ThemeColor = theme;
                    ThemeChanged?.Invoke(theme);
                };
                return ucTheme;
            });
        }

        private async void iconButtonMenu_Click(object sender, EventArgs e)
        {
            await HandleMenuButtonClick(iconButtonMenu, "ucDesign", () => new ucDesign());
        }

        private async Task HandleMenuButtonClick(IconButton clickedButton, string moduleKey, Func<UserControl> moduleFactory)
        {
            ResetMenuButtonColors();
            clickedButton.BackColor = _currentTheme.PointColor;
            await LoadModuleAsync(moduleKey, moduleFactory);
        }

        private void ResetMenuButtonColors()
        {
            foreach (var control in GetAllControls(this.panelMenu))
            {
                if (control is IconButton btn)
                    btn.BackColor = menuBackColor;
            }
        }

        private async Task LoadModuleAsync(string moduleKey, Func<UserControl> moduleFactory)
        {
            if (!loadedModules.TryGetValue(moduleKey, out var existingModule))
            {
                existingModule = moduleFactory();
                loadedModules[moduleKey] = existingModule;
            }

            if (panelControl.Controls.Count == 0 || panelControl.Controls[0].GetType() != existingModule.GetType())
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(existingModule);
                existingModule.Dock = DockStyle.Fill;
            }

            ApplyTheme(_currentTheme);
            await Task.CompletedTask;
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void iconButtonSaveClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
