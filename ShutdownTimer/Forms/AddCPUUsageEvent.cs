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
    internal partial class AddCPUUsageEvent : Form
    {
        public AddCPUUsageEvent()
        {
            InitializeComponent();
        }

        public CPUUsageEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                int usage = 0;
                int howLong = 0;
                int comparator = 0;

                usage = Convert.ToInt32(this.textBoxUsage.Text);
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

                return new CPUUsageEvent(usage, howLong, comparator);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}