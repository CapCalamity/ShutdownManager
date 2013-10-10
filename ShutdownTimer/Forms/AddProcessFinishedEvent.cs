using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ShutdownTimer.Classes;

namespace ShutdownTimer.Forms
{
    internal partial class AddProcessFinishedEvent : Form
    {
        public AddProcessFinishedEvent()
        {
            InitializeComponent();
            
            Process[] procs = Process.GetProcesses();
            
            foreach (Process proc in procs)
                this.comboBoxProcesses.Items.Add(proc.Id + " => " + proc.ProcessName);

            if (procs.Length > 0)
                this.comboBoxProcesses.SelectedItem = this.comboBoxProcesses.Items[0];
        }

        public ProcessFinishedEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                string selected = (string) this.comboBoxProcesses.SelectedItem;

                int procId = Convert.ToInt32(selected.Substring(0, selected.IndexOf(" =>")));

                return new ProcessFinishedEvent(procId);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}
