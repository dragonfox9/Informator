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
    public partial class InfoPanelWindow : Form
    {
        MainWindow mw;
        public InfoPanelWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (InfoPanelWindowStatus.infoPanelWindowEditMode == true)
            {
                DataBase.changeInfo((int)infoPanelStorage.index, titleTB.Text, msgTB.Text);
                InfoPanelWindowStatus.infoPanelWindowEditMode = false;
                InfoPanelWindowStatus.infoPanelWindowOpen = false;
                mw.pushNotDoneInfoToTop();
            }
            InfoPanelWindowStatus.infoPanelWindowEditMode = false;
            InfoPanelWindowStatus.infoPanelWindowOpen = false;
            Dispose();

        }

        private void InfoPanelWindow_Load(object sender, EventArgs e)
        {
            if (InfoPanelWindowStatus.infoPanelWindowEditMode)
            {
                closeBtn.Text = "Zapisz";
                titleTB.ReadOnly = false;
                msgTB.ReadOnly = false;
            }
            else
                closeBtn.Text = "Zamknij";
            titleTB.Text = infoPanelStorage.title;
            msgTB.Text = infoPanelStorage.msg;
            fromLb.Text = "Info od: " + infoPanelStorage.from;
            if (infoPanelStorage.doneBy != "")
                expiryDateLb.Text = "Wykonał: " + infoPanelStorage.doneBy;
            else
                expiryDateLb.Text = "Dodano: " + infoPanelStorage.expiryDate;
            addedByLb.Text = "Dodane przez: " + infoPanelStorage.addedBy;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void InfoPanelWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
