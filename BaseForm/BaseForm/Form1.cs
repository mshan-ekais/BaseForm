using BaseForm.Modules;
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

namespace BaseForm
{
    public partial class BorderlessMainForm : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize;

        private ThemeColors currentTheme = ThemeColors.NavyRedStyle;
        private Panel overlayPanel;

        private Dictionary<string, UserControl> loadedModules = new Dictionary<string, UserControl>();


        //Constructor
        public BorderlessMainForm()
        {
            InitializeComponent();
            //CollaseMenu();
            this.Padding = new Padding(borderSize); //Border size
            //CreateOverlay();
            //ColorChanged();
            ApplyTheme(currentTheme);
        }

        private void CreateOverlay()
        {
            overlayPanel = new Panel
            {
                BackColor = Color.FromArgb(120, 0, 0, 0), // 반투명 검정
                Dock = DockStyle.Fill,
                Visible = false
            };
            this.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParm, int lParm);


        private void Form_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            panelControl.Controls.Add(new ucHome() 
            { 
                Dock = DockStyle.Fill,
            });
        }

        private void ApplyTheme(ThemeColors theme)
        {
            currentTheme = theme;
            this.BackColor = theme.BackColor;
            this.panelTopBar.BackColor = theme.TopPanelColor;
            this.panelMenu.BackColor = theme.MenuPanelColor;
            this.panelLeft.BackColor = theme.PointColor;
            this.pictureBoxLogo.Image = theme.Image;


            //if (loadedModules.TryGetValue("ucEditForm", out var ctrl) && ctrl is ucEditForm editForm)
            //{
            //    editForm.ThemeColor = currentTheme;
            //}


            //if (loadedModules.TryGetValue("ucEditForm", out var ctrl) && ctrl is ucEditForm editForm)
            //{
            //    editForm.FontColor = theme.FontColor;
            //}


            foreach (var control in GetAllControls(this))
            {
                if (control is IconButton btn)
                {
                    if (btn.Tag != null && btn.Tag.ToString() == "button")
                    {
                        btn.BackColor = theme.ButtonColor;
                    }
                    btn.IconColor = theme.IconColor;
                    btn.ForeColor = theme.FontColor;
                }
                else
                {
                    control.ForeColor = theme.FontColor;
                }
            }
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

        protected void MakeFormDraggable(Control dragArea)
        {
            dragArea.MouseDown += (s, e) =>
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            };
        }

        private void panelControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            MakeFormDraggable(panelTopBar);
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
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
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Event methods
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

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

        private void iconButtonWindowMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonWindowMax_Click(object sender, EventArgs e)
        {
            windowMax();
        }

        private void windowMax()
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }


        private void iconButtonWindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            CollaseMenu();
        }

        private void CollaseMenu()
        {
            //throw new NotImplementedException();
            if (this.panelMenu.Width > 200)  //Collase menu
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                iconButtonMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {   //Expand menu
                panelMenu.Width = 230;
                pictureBoxLogo.Visible = true;
                iconButtonMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton.Tag.ToString() == "menu")
                    {
                        menuButton.ImageAlign = ContentAlignment.MiddleRight;
                        menuButton.Padding = new Padding(30, 30, 30, 30);
                    }
                    else
                    {
                        menuButton.Text = menuButton.Tag.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                        menuButton.Padding = new Padding(30, 10, 0, 10);
                    }
                }
            }
        }


        private async void iconButtonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = iconButtonHome.Height;
            panelLeft.Top = iconButtonHome.Top;
            await LoadModuleAsync("ucHome", () => new ucHome());
        }

        private async void iconButtonMeasure_Click(object sender, EventArgs e)
        {
            panelLeft.Height = iconButtonMeasure.Height;
            panelLeft.Top = iconButtonMeasure.Top;
            await LoadModuleAsync("ucMeasurement", () => new ucMeasurement());
        }


        private async void iconButtonDataLog_Click(object sender, EventArgs e)
        {
            panelLeft.Height = iconButtonDataLog.Height;
            panelLeft.Top = iconButtonDataLog.Top;
            await LoadModuleAsync("ucDataLog", () => new ucDataLog());
        }

        private async void iconButtonSetting_Click(object sender, EventArgs e)
        {
            panelLeft.Height = iconButtonSetting.Height;
            panelLeft.Top = iconButtonSetting.Top;
            await LoadModuleAsync("ucSetting", () => new ucSetting());
        }

        private async Task LoadModuleAsync(string moduleKey, Func<UserControl> moduleFactory)
        {
            if (!loadedModules.ContainsKey(moduleKey))
                loadedModules[moduleKey] = moduleFactory();

            panelControl.Controls.Clear();
            panelControl.Controls.Add(loadedModules[moduleKey]);
            loadedModules[moduleKey].Dock = DockStyle.Fill;

            await Task.CompletedTask;
        }

        private void iconButtonIEditForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;


            using (formEditForm editForm = new formEditForm())
            {
                editForm.Size = new Size(Convert.ToInt32(panelControl.Width * 0.8), Convert.ToInt32(panelControl.Height * 0.8));

                // 패널 기준 중심 좌표 계산
                int x = panelControl.Left + (panelControl.Width - editForm.Width) / 2;
                int y = panelControl.Top + (panelControl.Height - editForm.Height) / 2;

                editForm.StartPosition = FormStartPosition.Manual;
                editForm.Location = panelControl.PointToScreen(new Point(x - panelControl.Left, y - panelControl.Top));

                editForm.ThemeColor = currentTheme;
                editForm.ThemeChanged += theme =>
                {
                    this.ApplyTheme(theme); // MainForm에 테마 적용
                };

                var result = editForm.ShowDialog(); // 모달로 열기

                if (result == DialogResult.OK)
                {
                }
                else
                {
                }
            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            using (formPopup popup = new formPopup())
            {
                popup.Size = new Size(300, 200);
                popup.labelText.Text = "Are you sure you want to\nexit the program?";
                popup.ThemeColor = currentTheme;

                var result = popup.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //string value = popup.ResultText;
                }
                else
                {
                }
            }
        }
    }
}
