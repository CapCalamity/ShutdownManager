using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Classes
{
    abstract class Event
    {
        public virtual string _Name { get; protected set; }
        public virtual bool _Ready { get; protected set; }
        
        /// <summary>
        /// Check condition of event
        /// </summary>
        public abstract bool Ready();

        /// <summary>
        /// Get description of event, if it Fires
        /// </summary>
        public abstract string DescribeFireDescription();
    }
}