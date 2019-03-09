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
    public partial class AddNewUserWindow : Form
    {
        public AddNewUserWindow()
        {
            InitializeComponent();
        }

        private void AddNewUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Informator.Properties.Resources.x_red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Informator.Properties.Resources.x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (DataBase.createUser(textBox1.Text, textBox2.Text, 1))
                    this.Dispose();
                else
                    MessageBox.Show("Taki użytkownik już istnieje");
            }
            else
            {
                if (DataBase.createUser(textBox1.Text, textBox2.Text, 0))
                    this.Dispose();
                else
                    MessageBox.Show("Taki użytkownik już istnieje");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddNewUserWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
