using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParketTicketGenerator
{
    public class ParkingMeter
    {
        private int _purchTime;
        private int _timeOver;

        public ParkingMeter()
        {
            _purchTime = 0;
            _timeOver = 0;
        }

        public int PurchTime
        {
            get { return _purchTime; }
            set { _purchTime = value; }
        }

        public int TimeOver
        {
            get { return _timeOver; }
            set { _timeOver = value; }
        }
    }
}
