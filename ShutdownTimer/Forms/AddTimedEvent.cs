using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShutdownTimer.Classes;

namespace ShutdownTimer.Forms
{
    internal partial class AddTimedEvent : Form
    {
        public AddTimedEvent()
        {
            InitializeComponent();
        }

        public TimedEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                DateTime date = this.Date.Value;
                DateTime time = this.Time.Value;

                DateTime dt = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second, time.Millisecond);

                return new TimedEvent(dt);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}