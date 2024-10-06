using System.Diagnostics;
using System.Diagnostics.Tracing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace virus
{
    public partial class Form1 : Form
    {
        private const int WS_EX_TOOLWINDOW = 0x80;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        public Form1()
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.TopMost = true;


            InitializeComponent();
            SetWindowLong(Handle, -20, GetWindowLong(Handle, -20) | WS_EX_TOOLWINDOW);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Shift+A keys are pressed
            if (e.KeyCode == Keys.Q)
            {
                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Follow IG @limcuanhei");
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Show a message box
                MessageBox.Show("Follow IG @Your Instagram");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
