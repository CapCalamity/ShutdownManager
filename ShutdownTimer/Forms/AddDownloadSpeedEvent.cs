using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using ShutdownTimer.Classes;

namespace ShutdownTimer.Forms
{
    internal partial class AddDownloadSpeedEvent : Form
    {
        public AddDownloadSpeedEvent()
        {
            InitializeComponent();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface inter in interfaces)
                this.comboBoxAdapter.Items.Add(inter.Name);

            if (interfaces.Length > 0)
                this.comboBoxAdapter.SelectedItem = this.comboBoxAdapter.Items[0];
        }

        public DownloadSpeedEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                NetworkInterface inter = null;
                int received = 0;
                int howLong = 0;
                int comparator = 0;

                inter = (NetworkInterface) this.comboBoxAdapter.SelectedItem;

                received = Convert.ToInt32(this.textBoxReceived.Text);
                howLong = Convert.ToInt32(this.textBoxSeconds.Text);

                string selectedItem = (string) this.comboBoxComparator.SelectedItem;
                switch (selectedItem)
                {
                    case "Above":
                        comparator = 1;
                        break;
                    case "Precisely":
                        comparator = 0;
                        break;
                    case "Under":
                        comparator = -1;
                        break;
                    default:
                        break;
                }

                return new DownloadSpeedEvent(inter, received, howLong, comparator);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}
