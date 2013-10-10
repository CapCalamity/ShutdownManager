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
    internal partial class Main : Form
    {
        private Controller _Controller { get; set; }

        public Main(Controller controller)
        {
            InitializeComponent();

            _Controller = controller;

            this.comboBoxEvents.SelectedItem = this.comboBoxEvents.Items[0];
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            _Controller.EventTimer_Tick(sender, e);
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            string selected = this.comboBoxEvents.SelectedItem.ToString();
            Event ev = null;

            if (selected == "Timed")
            {
                AddTimedEvent form = new AddTimedEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else if (selected == "CPU Usage")
            {
                AddCPUUsageEvent form = new AddCPUUsageEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else if (selected == "HDD Usage")
            {
                AddHDDUsageEvent form = new AddHDDUsageEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else if (selected == "Download Speed")
            {
                AddDownloadSpeedEvent form = new AddDownloadSpeedEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else if (selected == "Upload Speed")
            {
                AddUploadSpeedEvent form = new AddUploadSpeedEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else if (selected == "Process Finished")
            {
                AddProcessFinishedEvent form = new AddProcessFinishedEvent();
                if (form.ShowDialog() == DialogResult.OK)
                    ev = form.GetEvent();
            }
            else
                throw new Exception("Could not handle input");

            if (ev != null)
                _Controller.AddEvent(ev);
        }

        public void SetReadyState(int rowIndex, bool ready)
        {
            if (ready)
                this.EventTable.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
            else
                this.EventTable.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
        }

        public int AddEvent(Event e)
        {
            this.textBoxEvents.AppendText("Adding event: " + e._Name + " => " + e.DescribeFireDescription() + "\r\n");

            return this.EventTable.Rows.Add(e, e._Name, e.DescribeFireDescription(), "Delete");
        }

        public int[] AddEventRange(IEnumerable<Event> e)
        {
            List<int> indexes = new List<int>();
            foreach (Event item in e)
                indexes.Add(this.AddEvent(item));
            return indexes.ToArray();
        }

        public void ClearTable()
        {
            this.EventTable.Rows.Clear();
        }

        public void StartTimer()
        {
            this.EventTimer.Start();
            this.ButtonStartTimer.Visible = false;
            this.ButtonStopTimer.Visible = true;
        }

        public void StopTimer()
        {
            this.EventTimer.Stop();
            this.ButtonStartTimer.Visible = true;
            this.ButtonStopTimer.Visible = false;
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            this.StartTimer();
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            this.StopTimer();
        }

        private void EventTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.EventTable.Columns["ColDelete"].Index)
                _Controller.Delete((Event) this.EventTable.Rows[e.RowIndex].Cells["ColObject"].Value);
        }
    }
}