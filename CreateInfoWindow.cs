using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informator
{
    public partial class CreateInfoWindow : Form
    {
        CalendarWindow calendar;
        MainWindow mw;
        public CreateInfoWindow(MainWindow mw)
        {
            InitializeComponent();
            calendar = new CalendarWindow(this);
            this.mw = mw;
        }

        private void CreateInfoWindow_Load(object sender, EventArgs e)
        {
            expiryDateLabel.Text = DateTime.Now.ToShortDateString();
            radioButton2.Text = UserInfo.userName;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Properties.Resources.x_red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Properties.Resources.x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            createCalendar();
        }

        private void createCalendar()
        {
            calendar.StartPosition = FormStartPosition.Manual;
            calendar.Location = new Point(Cursor.Position.X - 5, Cursor.Position.Y - 5);
            calendar.Show();
        }

        public void setExpiryDate(string expiryDate)
        {
            expiryDateLabel.Text = expiryDate;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = !panel3.Enabled;
        }

        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            string from = string.Empty;
            string title = textBox2.Text;
            string msg = textBox1.Text;
            string addedBy = UserInfo.userName;
            long important = 0;

            if (radioButton3.Checked)
                from = "Szef";
            else if (radioButton1.Checked)
                from = "Biuro";
            else if (radioButton2.Checked)
                from = UserInfo.userName;

            if (radioButton4.Checked)
                important = 1;
            else if (radioButton5.Checked)
                important = 2;
            else if (radioButton6.Checked)
                important = 3;

            mw.addInfo(0,from, title, msg, Date.getDate().ToShortDateString(), addedBy, important, 0);
            DataBase.addInfo(GlobalInfoPanelndex.currentIndex, from, title, msg, Date.getDate(), addedBy, important, 0);
            mw.pushNotDoneInfoToTop();
            this.Dispose();
        }
    }
}
