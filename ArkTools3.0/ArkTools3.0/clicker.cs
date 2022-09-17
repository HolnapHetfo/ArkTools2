using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkTools3._0
{
    public partial class clicker : Form
    {
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public clicker()
        {
            InitializeComponent();
        }

        private void CPSTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = "CPS: " + CPSTrackBar.Value.ToString();
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (BtnToggle.Text.Contains("Enable"))
            {
                BtnToggle.ForeColor = Color.FromArgb(80, 80, 80);
                BtnToggle.FillColor = Color.DarkOrange;
                BtnToggle.Text = "Disable";
            }
            else if (BtnToggle.Text.Contains("Disable"))
            {
                BtnToggle.ForeColor = Color.DarkOrange;
                BtnToggle.FillColor = Color.FromArgb(80, 80, 80);
                BtnToggle.Text = "Enable";
            }
        }

        private void BtnToggle_TextChanged(object sender, EventArgs e)
        {
            if (BtnToggle.Text.Contains("Disable"))
            {
                AutoClicker.Start();

            }
            else
            {
                AutoClicker.Stop();
            }
        }


        int min;
        int max;
        IntPtr hwnd;

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            if (BtnToggle.Text.Contains("Disable"))
            {
                min = CPSTrackBar.Value - 6;
                max = CPSTrackBar.Value + 6;
                Random random = new Random();
                Bar2.Value = (random.Next(min, max));
            }
        }

        private async void AutoClicker_Tick(object sender, EventArgs e)
        {
            debugLabel1.Text = "Elindult";
            try
            {
                AutoClicker.Interval = (1000 / Bar2.Value);
            }
            catch { }
            if (BtnToggle.Text.Contains("Disable"))
            {
                //MessageBox.Show("asdasdasd"); mukodik
                Process[] processes = Process.GetProcessesByName("ShooterGame");
                //debugLabel1.Text = processes.Length + "Pross lenght";
                //MessageBox.Show(processes.Length + "asd");
                foreach (Process process in processes)
                {
                    //MessageBox.Show(process.MainWindowTitle);
                    hwnd = FindWindow(null, process.MainWindowTitle);
                }
                string currentWindow = getActiveWindowName();
                //MessageBox.Show(currentWindow);
                //debugLabel1.Text = currentWindow;
                if (currentWindow == null)
                {
                    return;
                }
                if (currentWindow == "ShooterGame")
                {
                    //MessageBox.Show("CLICK");
                    debugLabel1.Text = "CLICK";
                    if (true)
                    {
                        PostMessage(hwnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hwnd, 0x0202, 0, 0);
                    }
                }
            }
        }
    }
}
