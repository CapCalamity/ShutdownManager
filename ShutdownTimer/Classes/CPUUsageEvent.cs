using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Classes
{
    class CPUUsageEvent : Event
    {
        private int _TrueFor { get; set; }
        private int _Usage { get; set; }
        private int _ToBeFor { get; set; }
        private int _Comparator { get; set; }

        public CPUUsageEvent(int usage, int seconds, int comp)
        {
            _Usage = usage;
            _ToBeFor = seconds;
            _Comparator = comp;
            _Name = "CPU Usage Event";
        }

        public override bool Ready()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            float usage = cpuCounter.NextValue();

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
            return "CPU Usage is " + c + " " + _Usage + "% for at least " + _ToBeFor + " seconds";
        }
    }
}