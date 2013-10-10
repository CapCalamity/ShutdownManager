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
    internal partial class AddHDDUsageEvent : Form
    {
        private static string[] _Categories = new PerformanceCounterCategory("PhysicalDisk").GetInstanceNames();

        public AddHDDUsageEvent()
        {
            InitializeComponent();

            foreach (string categorie in AddHDDUsageEvent._Categories)
                this.comboBoxHDD.Items.Add(categorie);

            if (AddHDDUsageEvent._Categories.Length > 0)
                this.comboBoxHDD.SelectedItem = this.comboBoxHDD.Items[0];
        }

        public HDDUsageEvent GetEvent()
        {
            if (this.DialogResult != DialogResult.OK)
                throw new Exception("Couldn't create Event");

            try
            {
                string categorie = "";
                int usage = 0;
                int howLong = 0;
                int comparator = 0;

                categorie = (string) this.comboBoxHDD.SelectedItem;

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

                return new HDDUsageEvent(categorie, usage, howLong, comparator);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't create Event");
            }
        }
    }
}
