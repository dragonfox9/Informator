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
    public partial class CalendarWindow : Form
    {
        CreateInfoWindow windowInfo;
        public CalendarWindow(CreateInfoWindow windowInfo)
        {
            InitializeComponent();
            this.windowInfo = windowInfo;
        }

        private void CalendarWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void CalendarWindow_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            windowInfo.setExpiryDate(date.ToShortDateString());
            Date.setDate(date);
            this.Hide();
        }
    }
}
