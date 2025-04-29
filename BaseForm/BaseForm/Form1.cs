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
using static BaseForm.Controls.MenuManager;

namespace BaseForm
{

    public partial class BorderlessMainForm : Form
    {
        private int borderSize = 2;
        
        private Size formSize;
        private ThemeColors currentTheme = ThemeColors.KaisStyle;
        private DockStyle currentDockStyle = DockStyle.Top;
        private Dictionary<string, UserControl> loadedModules = new Dictionary<string, UserControl>();

        private ucMenuVertical ucMenuVertical;
        private ucMenuHorizontal ucMenuHorizontal;

        //Constructor
        public BorderlessMainForm()
        {
            InitializeComponent();
            InitializeMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParm, int lParm);


        private void InitializeMenu()
        {
            ucMenuVertical = new ucMenuVertical();
            ucMenuVertical.Dock = DockStyle.Left;

            ucMenuVertical.CollapseToggled += OnMenuCollapseToggled;
            ucMenuVertical.MenuButtonClicked += OnMenuButtonClicked;

            this.Controls.Add(ucMenuVertical);
            ucMenuVertical.BringToFront();


            ucMenuHorizontal = new ucMenuHorizontal();
            ucMenuHorizontal.Dock = DockStyle.Left;
            //ucMenuHorizontal.CollapseToggled += OnMenuCollapseToggled;
            ucMenuHorizontal.MenuButtonClicked += OnMenuButtonClicked;

            this.Controls.Add(ucMenuHorizontal);
            ucMenuHorizontal.BringToFront();
            ucMenuHorizontal.Visible = true;

            switch (currentDockStyle)
            {
                case DockStyle.Left:
                    break;
                case DockStyle.Top:
                    break;
                case DockStyle.Right:
                    break;
                case DockStyle.Bottom:
                    break;
            }

        }

        private async void Form_Load(object sender, EventArgs e)
        {
            this.formSize = this.ClientSize;
            this.Padding = new Padding(borderSize); //Border size

            ApplyTheme(currentTheme);
            ApplyDockStyle(currentDockStyle);

            await Task.Delay(1);
            OnMenuButtonClicked(MenuButtonType.Home);
        }


        private void ApplyTheme(ThemeColors theme)
        {
            currentTheme = theme;
            this.BackColor = theme.BackColor;
            this.panelTopBar.BackColor = theme.TopPanelColor;

            ucMenuVertical.BackColor = theme.MenuPanelColor;
            ucMenuVertical.panelBar.BackColor = theme.PointColor;
            ucMenuVertical.pictureBoxLogo.Image = theme.Image;

            ucMenuHorizontal.BackColor = theme.MenuPanelColor;
            ucMenuHorizontal.panelBar.BackColor = theme.PointColor;
            ucMenuHorizontal.pictureBoxLogo.Image = theme.Image;

            foreach (var control in GetAllControls(this))
            {
                if (control is IconButton btn)
                {
                    //if (btn.Tag is ControlType controlType && controlType == ControlType.Button)
                    //{
                    //    btn.BackColor = theme.ButtonColor;
                    //}
                    //btn.IconColor = theme.IconColor;
                    //btn.ForeColor = theme.FontColor;
                }
                control.ForeColor = theme.FontColor;
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

        private void OnMenuCollapseToggled()
        {
            CollapseMenu(); // 메인 폼 전체 레이아웃 수정
        }

        public void CollapseMenu()
        {
            if (this.ucMenuVertical.Width > 200)  //Collase menu
            {
                this.ucMenuVertical.Width = 100;
                this.ucMenuVertical.pictureBoxLogo.Visible = false;
                this.ucMenuVertical.iconButtonMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in GetCollapseMenuButtons(this.ucMenuVertical))
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {   //Expand menu
                this.ucMenuVertical.Width = 230;
                this.ucMenuVertical.pictureBoxLogo.Visible = true;
                this.ucMenuVertical.iconButtonMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in GetCollapseMenuButtons(this.ucMenuVertical))
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

        private IEnumerable<Button> GetCollapseMenuButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn)
                    yield return btn;

                if (control.HasChildren)
                {
                    foreach (var childButton in GetCollapseMenuButtons(control))
                        yield return childButton;
                }
            }
        }

        private int GetRelativePosition(Control button, Control container, bool isVertical)
        {
            var btnScreenPos = button.Parent.PointToScreen(button.Location);
            var containerScreenPos = container.PointToScreen(Point.Empty);

            return isVertical ? (btnScreenPos.Y - containerScreenPos.Y)
                              : (btnScreenPos.X - containerScreenPos.X);
        }

        private async void OnMenuButtonClicked(MenuButtonType buttonType)
        {
            IconButton selectedButton;

            if (currentDockStyle == DockStyle.Left || currentDockStyle == DockStyle.Right)
            {
                selectedButton = ucMenuVertical.GetButton(buttonType);

                int relativeTop = GetRelativePosition(selectedButton, ucMenuVertical, true);

                ucMenuVertical.PanelLeft.Top = relativeTop;
                ucMenuVertical.PanelLeft.Height = selectedButton.Height;
            }
            else if (currentDockStyle == DockStyle.Top || currentDockStyle == DockStyle.Bottom)
            {
                selectedButton = ucMenuHorizontal.GetButton(buttonType);

                int relativeLeft = GetRelativePosition(selectedButton, ucMenuHorizontal, false);

                ucMenuHorizontal.PanelBar.Left = relativeLeft;
                ucMenuHorizontal.PanelBar.Width = selectedButton.Width;
            }
            else
                return;


            switch (buttonType)
            {
                case MenuButtonType.Home:
                    await LoadModuleAsync("ucHome", () => new ucHome());
                    break;
                case MenuButtonType.Measure:
                    await LoadModuleAsync("ucMeasurement", () => new ucMeasurement());
                    break;
                case MenuButtonType.DataLog:
                    await LoadModuleAsync("ucDataLog", () => new ucDataLog());
                    break;
                case MenuButtonType.Setting:
                    await LoadModuleAsync("ucSetting", () => new ucSetting());
                    break;
                case MenuButtonType.EditForm:
                    iconButtonIEditForm_Click();
                    break;
                case MenuButtonType.Close:
                    iconButtonClose_Click();
                    break;
            }
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

        private void iconButtonIEditForm_Click()
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
                    this.ApplyTheme(theme);
                };

                editForm.DockMenuStyle = currentDockStyle;
                editForm.DockStyleChanged += style =>
                {
                    this.ApplyDockStyle(style);
                };


                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                }
                else
                {
                }
            }
        }


        public void ApplyDockStyle(DockStyle dockStyle)
        {
            currentDockStyle = dockStyle;

            if (dockStyle == DockStyle.Left || dockStyle == DockStyle.Right)
            {
                ucMenuVertical.Dock = dockStyle;
                ucMenuVertical.Visible = true;
                ucMenuHorizontal.Visible = false;
            }
            else if (dockStyle == DockStyle.Top || dockStyle == DockStyle.Bottom)
            {
                ucMenuHorizontal.Dock = dockStyle;
                ucMenuHorizontal.Visible = true;
                ucMenuVertical.Visible = false;
            }
            else
            {
                return;
            }

            // 레이아웃 적용 이후 위치 재설정
            this.BeginInvoke(new Action(FixPanelPosition));
            
        }

        private void FixPanelPosition()
        {
            if (currentDockStyle == DockStyle.Left || currentDockStyle == DockStyle.Right)
            {
                ucMenuVertical.PanelLeft.Top = GetRelativePosition(ucMenuVertical.iconButtonEditForm, ucMenuVertical, true);
            }
            else if (currentDockStyle == DockStyle.Top || currentDockStyle == DockStyle.Bottom)
            {
                ucMenuHorizontal.PanelBar.Left = GetRelativePosition(ucMenuHorizontal.iconButtonEditForm, ucMenuHorizontal, false);
            }
        }


        private void iconButtonClose_Click()
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
