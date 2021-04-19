using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat_constructor
{
    class Meetlat
    {
        private double _lengteInMeter;
        public Meetlat()
        {

        }
        public Meetlat(double lengteInMeter)
        {
            _lengteInMeter = lengteInMeter;
        }
        public double BeginLengte 
        {
            set
            {
                _lengteInMeter = value;
            }
        }
        public double LengteInM
        {
            get
            {
                return _lengteInMeter;
            }
        }
        public double LengteInCm
        {
            get
            {
                return _lengteInMeter * 10;
            }
        }
        public double LengteInKm
        {
            get
            {
                return _lengteInMeter / 1000;
            }
        }
        public double LengteInVoet
        {
            get
            {
                return _lengteInMeter * 3.2808;
            }
        }
    }
}
