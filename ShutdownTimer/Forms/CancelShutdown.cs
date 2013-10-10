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

namespace ShutdownTimer.Forms
{
    public partial class CancelShutdown : Form
    {
        private Controller _Controller { get; set; }

        internal CancelShutdown(Controller c, int seconds)
        {
            _Controller = c;
            InitializeComponent();
            this.labelShutdownSeconds.Text = seconds.ToString();
            this.timerShutdown.Start();
        }

        private void buttonCancelShutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            this.timerShutdown.Stop();

            _Controller.AbortedShutdown();
            this.Close();
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            int secs = Convert.ToInt32(this.labelShutdownSeconds.Text);
            --secs;
            this.labelShutdownSeconds.Text = secs.ToString();
        }
    }
}