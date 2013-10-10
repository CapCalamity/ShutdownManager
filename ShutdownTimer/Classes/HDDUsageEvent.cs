using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Classes
{
    class HDDUsageEvent : Event
    {
        private int _Usage { get; set; }
        private int _ToBeFor { get; set; }
        private int _Comparator { get; set; }
        private int _TrueFor { get; set; }
        private string _Category { get; set; }

        public HDDUsageEvent(string cat, int usage, int seconds, int comp)
        {
            _Usage = usage;
            _ToBeFor = seconds;
            _Comparator = comp;
            _Category = cat;
            _Name = "HDD Usage Event";
        }

        public override bool Ready()
        {
            PerformanceCounter counter = new PerformanceCounter("PhysicalDisk", "Disk Transfers/sec", _Category);
            float usage = counter.NextValue();
            if (_Comparator < 0)
            {
                if (usage < _Usage)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator == 0)
            {
                if (usage == _Usage)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator > 0)
            {
                if (usage > _Usage)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }

            if (_TrueFor >= _ToBeFor)
                return _Ready = true;
            else
                return _Ready = false;
        }

        public override string DescribeFireDescription()
        {
            string c = "";
            if (_Comparator < 0)
                c = "below";
            else if (_Comparator == 0)
                c = "precisely";
            else if (_Comparator > 0)
                c = "above";
            return "HDD Reads/Writes is " + c + " " + _Usage + " for at least " + _ToBeFor + " seconds";
        }
    }
}