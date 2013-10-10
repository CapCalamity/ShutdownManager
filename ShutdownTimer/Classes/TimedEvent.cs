using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Classes
{
    class TimedEvent : Event
    {
        private DateTime _Time { get; set; }

        public TimedEvent(DateTime time)
        {
            _Time = time;
            _Name = "Timed Event";
        }

        public override bool Ready()
        {
            DateTime now = DateTime.Now;
            
            if (now.Ticks > _Time.Ticks)
                return _Ready = true;
            else
                return _Ready = false;
        }

        public override string DescribeFireDescription()
        {
            return "After " + _Time.Year + "." + _Time.Month + "." + _Time.Day + " " + _Time.Hour + ":" + _Time.Minute + ":" + _Time.Second;
        }
    }
}