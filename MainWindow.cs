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
    public partial class MainWindow : Form
    {
        private CreateInfoWindow infoWindow;
        private bool firstPanel = true;
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LastInfoPanelPosition.set(new Point(10, 0));
            label1.Text = UserInfo.userName;
            setAdmin();
            DataBase.loadAllInfo(this);
            DataBase.setGlobalIndex();

            //Drawing separating lines in top table
            tablePanel.Paint += (s, ev) =>
            {
                var g = ev.Graphics;
                Pen pen = new Pen(Color.FromArgb(90, 90, 90));
                Point p1 = new Point(136, 0);
                Point p2 = new Point(136, 50);
                Point p3 = new Point(261, 0);
                Point p4 = new Point(261, 100);
                Point p5 = new Point(386, 0);
                Point p6 = new Point(386, 100);

                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p3, p4);
                g.DrawLine(pen, p5, p6);
            };
        }

        //makeing form movable by mouse 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Informator.Properties.Resources.x_red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Informator.Properties.Resources.x;
        }

        //closing app when main form is closing
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //showing window with panel to add new information
        private void addInfoBtn_Click(object sender, EventArgs e)
        {
            infoWindow = new CreateInfoWindow(this);
            infoWindow.Show();
        }

        //creating new panel with all components and showing in main panel
        public void addInfo(long index, string from, string title, string msg, string expiryDate, string addedBy, long isImportant, long isDone)
        {

            Console.WriteLine("index = {0}",index);
            if (index == 0)
                GlobalInfoPanelndex.currentIndex++;
            else
                GlobalInfoPanelndex.currentIndex = index;
            Console.WriteLine("Current global index: " + GlobalInfoPanelndex.currentIndex);
            //Creating panel to display all informations
            Panel infoPanel = new Panel();
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Size = new Size(610, 30);
            infoPanel.Cursor = Cursors.Hand;
            infoPanel.Location = new Point(LastInfoPanelPosition.get().X, LastInfoPanelPosition.get().Y + 10 + (infoMainPanel.Controls.Count == 0 ? 0 : infoPanel.Height));
            infoPanel.TabIndex = (int)GlobalInfoPanelndex.currentIndex;
            LastInfoPanelPosition.set(infoPanel.Location);

            //Creating label with text from who is message
            Label fromLabel = new Label();
            fromLabel.ForeColor = SystemColors.AppWorkspace;
            fromLabel.Text = from;
            fromLabel.Location = new Point(10, 8);

            //Creating label with title
            Label titleLabel = new Label();
            titleLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            titleLabel.Text = title;
            titleLabel.Location = new Point(fromLabel.Location.X + fromLabel.Width + 25, 8);
            titleLabel.AutoEllipsis = true;

            //Creating label with expiryDate
            Label expiryDateLabel = new Label();
            expiryDateLabel.ForeColor = SystemColors.AppWorkspace;
            expiryDateLabel.Text = expiryDate;
            expiryDateLabel.Location = new Point(titleLabel.Location.X + titleLabel.Width + 25, 8);

            //Creating label with "Days left" information
            Label daysLeftLb = new Label();
            daysLeftLb.ForeColor = SystemColors.AppWorkspace;
            if (isDone == 0)
            {
                TimeSpan diff = DateTime.Now - DateTime.Parse(expiryDate);
                int days = (int)Math.Abs(Math.Round(diff.TotalDays));
                if (Date.isExpired(DateTime.Parse(expiryDate)))
                    daysLeftLb.Text = "Zrób to dziś!";
                else
                    daysLeftLb.Text = days.ToString() + " dni";

                if (days == 0)
                {
                    TimeSpan ts = DateTime.Parse(expiryDate) - DateTime.Now;
                    int hours = (int)Math.Abs(Math.Round(ts.TotalHours));
                    daysLeftLb.Text = hours.ToString() + " godziny";
                }
            }
            daysLeftLb.Location = new Point(expiryDateLabel.Location.X + expiryDateLabel.Width + 25, 8);

            List<Control> pbs = new List<Control>();
            //creating delete button
            PictureBox deleteBtn = new PictureBox();
            deleteBtn.Size = new Size(25, 25);
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.BackgroundImage = Informator.Properties.Resources.deleteBtn_normal;
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbs.Add(deleteBtn);
            if (!UserInfo.getAdminPermissions())
                deleteBtn.Visible = false;

            //creating "done" button
            PictureBox doneBtn = new PictureBox();
            doneBtn.Size = new Size(25, 25);
            doneBtn.BackColor = Color.Transparent;
            doneBtn.BackgroundImage = Informator.Properties.Resources.acceptBtn_normal1;
            doneBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbs.Add(doneBtn);
            if (isDone==1)
            {
                doneBtn.Visible = false;
            }

            //creating "edit" button if owner (or admin) of specific information is logged in.
            PictureBox editBtn = new PictureBox();
            editBtn.Size = new Size(25, 25);
            editBtn.BackColor = Color.Transparent;
            editBtn.BackgroundImage = Informator.Properties.Resources.editBtn_normal;
            editBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbs.Add(editBtn);
            editBtn.Visible = false;
            if (DataBase.isInfoOwner(infoPanel.TabIndex, UserInfo.userName) == true || UserInfo.getAdminPermissions() == true)
                editBtn.Visible = true;

            //creationg "check info" button
            PictureBox checkInfoBtn = new PictureBox();
            checkInfoBtn.Size = new Size(25, 25);
            checkInfoBtn.BackColor = Color.Transparent;
            checkInfoBtn.BackgroundImage = Informator.Properties.Resources.checkInfoBtn_normal;
            checkInfoBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbs.Add(checkInfoBtn);

            //drawing buttons
            Point firstLoc = new Point(infoPanel.Width - 30, 2);
            int lastControl = -1;
            for(int i = 0; i < pbs.Count;i++)
            {
                if (pbs[i].Visible)
                {
                    if (lastControl == -1)
                    {
                        pbs[i].Location = firstLoc;
                        lastControl = 1;
                    }
                    else
                    {
                        Console.WriteLine(lastControl);
                        pbs[i].Location = new Point(infoPanel.Width - (pbs[i].Width * lastControl + 3), 0);
                    }
                    lastControl++;
                }
            }

            //creating dynamic click event on edit button
            editBtn.Click += (s, e) =>
            {
                if (!InfoPanelWindowStatus.infoPanelWindowOpen)
                {
                    DataBase.loadInfoToPanel(infoPanel.TabIndex);
                    InfoPanelWindow ipw = new InfoPanelWindow(this);
                    InfoPanelWindowStatus.infoPanelWindowOpen = true;
                    InfoPanelWindowStatus.infoPanelWindowEditMode = true;
                    ipw.Show();
                }
            };

            //creating dynamic click event on done button
            doneBtn.Click += (s, e) =>
            {
                DataBase.setIsDoneFlag(infoPanel.TabIndex, 1, UserInfo.userName);
                doneBtn.Visible = false;
                expiryDateLabel.Text = "Zatwierdzone";
                daysLeftLb.Text = "";
                pushNotDoneInfoToTop();
            };

            //creating dynamic click event on delete button
            deleteBtn.Click += (s, e) => 
            {
                Console.WriteLine("Deleting index: " + infoPanel.TabIndex);
                foreach (Control obj in infoMainPanel.Controls)
                    if(obj.TabIndex == infoPanel.TabIndex)
                    {
                        infoMainPanel.Controls.Remove(obj);
                        sortInfoInPanel();
                    }
                DataBase.deleteInfo(infoPanel.TabIndex);
                Console.WriteLine("Removed index: " + infoPanel.TabIndex);
            };

            //drawing delete info button in info panel

            //Drawing line on infoPanel
            infoPanel.Paint += (s, e) =>
            {
                var g = e.Graphics;
                Pen pen = new Pen(Color.FromArgb(90, 90, 90));
                Point p1 = new Point(titleLabel.Location.X + titleLabel.Width + 15, 0);
                Point p2 = new Point(titleLabel.Location.X + titleLabel.Width + 15, 50);
                Point p3 = new Point(fromLabel.Location.X + fromLabel.Width + 15, 0);
                Point p4 = new Point(fromLabel.Location.X + fromLabel.Width + 15, 100);
                Point p5 = new Point(expiryDateLabel.Location.X + expiryDateLabel.Width + 15, 0);
                Point p6 = new Point(expiryDateLabel.Location.X + expiryDateLabel.Width + 15, 100);

                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p3, p4);
                g.DrawLine(pen, p5, p6);
            };

            checkInfoBtn.Click += (s, e) => 
            {
                if (!InfoPanelWindowStatus.infoPanelWindowOpen)
                {
                    DataBase.loadInfoToPanel(infoPanel.TabIndex);
                    InfoPanelWindow ipw = new InfoPanelWindow(this);
                    InfoPanelWindowStatus.infoPanelWindowOpen = true;
                    ipw.Show();
                }
            };

            //attaching all controls to panels
            infoPanel.Controls.Add(checkInfoBtn);
            infoPanel.Controls.Add(editBtn);
            infoPanel.Controls.Add(doneBtn);
            infoPanel.Controls.Add(daysLeftLb);
            infoPanel.Controls.Add(deleteBtn);
            infoPanel.Controls.Add(fromLabel);
            infoPanel.Controls.Add(expiryDateLabel);
            infoPanel.Controls.Add(titleLabel);
            infoMainPanel.Controls.Add(infoPanel);
            sortInfoInPanel();
        }

        public void pushNotDoneInfoToTop()
        {
            infoMainPanel.Controls.Clear();
            DataBase.loadAllInfo(this);
            DataBase.setGlobalIndex();
        }

        //refreshing and sorting informations in panel, adding next pages if infoMainPanel.Controls.Count > 10
        private void sortInfoInPanel()
        {
            if (page == 1)
            {
                firstPanel = true;
                LastInfoPanelPosition.set(new Point(10, 0));
                for (int i = 0; i < infoMainPanel.Controls.Count; i++)
                    infoMainPanel.Controls[i].Visible = false;
                for (int i = 0; i < infoMainPanel.Controls.Count; i++)
                {
                    if (i < 10)
                    {
                        infoMainPanel.Controls[i].Visible = true;
                        repositionInfoPanel(i);
                    }
                    if (i == 10 * lastPage)
                    {
                        lastPage++;
                        lastPageLb.Text = "ilość stron: " + lastPage;
                    }
                }
            }

            if (page >= 1 && page < lastPage)
                nextPageBtn.Enabled = true;
            else if (page == 1)
                nextPageBtn.Enabled = false;
            else if (page == lastPage)
                nextPageBtn.Enabled = false;
            if (page > 1)
                previousPageBtn.Enabled = true;
            else
                previousPageBtn.Enabled = false;

            if (page > 1)
            {
                firstPanel = true;
                LastInfoPanelPosition.set(new Point(10, 0));
                for (int i = 0; i < infoMainPanel.Controls.Count; i++)
                        infoMainPanel.Controls[i].Visible = false;
                for (int i = 10 * (page - 1); i < (infoMainPanel.Controls.Count > (10 * page ) ? 10 * page : infoMainPanel.Controls.Count); i++)
                {
                        infoMainPanel.Controls[i].Visible = true;
                        repositionInfoPanel(i);
                }
            }
        }

        //repositioning specific info panel if needed
        private void repositionInfoPanel(int index)
        {
            if (firstPanel)
            {
                infoMainPanel.Controls[index].Location = new Point(LastInfoPanelPosition.get().X, LastInfoPanelPosition.get().Y + 10);
                firstPanel = false;
            }
            else
                infoMainPanel.Controls[index].Location = new Point(LastInfoPanelPosition.get().X, LastInfoPanelPosition.get().Y + 10 + infoMainPanel.Controls[index].Height);
            LastInfoPanelPosition.set(infoMainPanel.Controls[index].Location);
        }

        int lastPage = 1;
        int page = 1;
        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            if (page < lastPage)
            {
                page++;
                pageTB.Text = page.ToString();
                sortInfoInPanel();
            }
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                pageTB.Text = page.ToString();
                sortInfoInPanel();
            }
        }

        private void pageTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pageNumber;
                Int32.TryParse(pageTB.Text, out pageNumber);
                if (pageNumber <= lastPage && pageNumber >= 1)
                {
                    page = pageNumber;
                    sortInfoInPanel();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pageTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewUserWindow newUserWindow = new AddNewUserWindow();
            newUserWindow.Show();
        }

        //only user with admin privileges can see delete button
        private void setAdmin()
        {
            if(!UserInfo.getAdminPermissions())
            {
                button1.Visible = false;
            }
        }
    }
}
