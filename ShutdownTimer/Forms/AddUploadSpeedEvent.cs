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
    internal partial class AddUploadSpeedEvent : Form
    {
        public AddUploadSpeedEvent()
        {
            InitializeComponent();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface inter in interfaces)
                this.comboBoxAdapter.Items.Add(inter.Name);

            if (interfaces.Length > 0)
                this.comboBoxAdapter.SelectedItem = this.comboBoxAdapter.Items[0];
        }

        public UploadSpeedEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                NetworkInterface inter = null;
                int sent = 0;
                int howLong = 0;
                int comparator = 0;

                inter = (NetworkInterface) this.comboBoxAdapter.SelectedItem;

                sent = Convert.ToInt32(this.textBoxSent.Text);
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

                return new UploadSpeedEvent(inter, sent, howLong, comparator);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}
