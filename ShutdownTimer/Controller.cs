using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShutdownTimer.Forms;
using ShutdownTimer.Classes;
using System.Diagnostics;

namespace ShutdownTimer
{
    class Controller
    {
        private Main _Main { get; set; }
        private List<Event> _Events { get; set; }
        private Process _ShutdownProcess { get; set; }

        public Controller()
        {
            _ShutdownProcess = null;
            _Events = new List<Event>();
            _Main = new Main(this);
        }

        public void Run()
        {
            Application.Run(_Main);
        }

        public void AddEvent(Event e)
        {
            _Events.Add(e);
            _Main.AddEvent(e);
        }

        internal void EventTimer_Tick(object sender, EventArgs e)
        {
            if (_ShutdownProcess == null)
            {
                _Main.ClearTable();
                List<bool> readyItems = new List<bool>(_Events.Count);
                foreach (Event item in _Events)
                {
                    bool ready = item.Ready();
                    int index = _Main.AddEvent(item);
                    _Main.SetReadyState(index, ready);
                    readyItems.Add(ready);
                }

                //if all elements in the list are 'true'
                if (readyItems.TrueForAll(item => { return item; }))
                    this.InitiateShutdown();
            }
        }

        internal void InitiateShutdown()
        {
            if (_ShutdownProcess == null)
            {
                int seconds = 30;

                CancelShutdown shutdownForm = new CancelShutdown(this, seconds);
                shutdownForm.Show();
                _ShutdownProcess = Process.Start("shutdown", "/s /t " + seconds);
            }
        }

        internal void AbortedShutdown()
        {
            if(_ShutdownProcess != null && !_ShutdownProcess.HasExited)
                _ShutdownProcess.Kill();
            _ShutdownProcess = null;
            _Main.StopTimer();
        }

        internal void Delete(Event e)
        {
            int index = _Events.FindIndex(item => { return item == e; });
            if (index >= 0)
            {
                _Events.RemoveAt(index);
                _Main.ClearTable();
                _Main.AddEventRange(_Events);
            }
        }
    }
}