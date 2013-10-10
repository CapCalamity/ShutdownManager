using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace ShutdownTimer.Classes
{
    class DownloadSpeedEvent : Event
    {
        private NetworkInterface _Interface { get; set; }
        private int _Received { get; set; }
        private int _ToBeFor { get; set; }
        private int _Comparator { get; set; }
        private int _TrueFor { get; set; }
        private long _LastValue { get; set; }

        public DownloadSpeedEvent(NetworkInterface inter, int received, int seconds, int comp)
        {
            _Interface = inter;
            _Received = received;
            _ToBeFor = seconds;
            _Comparator = comp;
            _LastValue = inter.GetIPv4Statistics().BytesReceived;
            _Name = "Download Speed Usage Event";
        }

        public override bool Ready()
        {
            long bytesReceived = _Interface.GetIPv4Statistics().BytesReceived - _LastValue;
            _LastValue = _Interface.GetIPv4Statistics().BytesReceived;
            
            if (_Comparator < 0)
            {
                if (bytesReceived < _Received)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator == 0)
            {
                if (bytesReceived == _Received)
                    ++_TrueFor;
                else
                    _TrueFor = 0;
            }
            else if (_Comparator > 0)
            {
                if (bytesReceived > _Received)
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
            return "Download Speed is " + c + " " + _Received / 1024 + "kB/s for at least " + _ToBeFor + " seconds";
        }
    }
}