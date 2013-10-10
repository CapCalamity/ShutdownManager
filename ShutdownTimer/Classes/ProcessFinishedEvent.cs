using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Classes
{
    class ProcessFinishedEvent : Event
    {
        private int _ProcessID { get; set; }

        public ProcessFinishedEvent(int processID)
        {
            _ProcessID = processID;
            _Name = "Process Event";
        }

        public override bool Ready()
        {
            try
            {
                Process proc = Process.GetProcessById(_ProcessID);
            }
            catch (ArgumentException)
            {
                return _Ready = true;
            }

            return _Ready = false;
        }

        public override string DescribeFireDescription()
        {
            return "Process " + Process.GetProcessById(_ProcessID).ProcessName + " terminated";
        }
    }
}