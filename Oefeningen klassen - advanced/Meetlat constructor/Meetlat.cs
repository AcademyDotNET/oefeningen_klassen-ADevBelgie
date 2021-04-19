using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat_constructor
{
    class Meetlat
    {
        public Meetlat()
        {

        }

        double Lengte;
        public double BeginLengte 
        {
            set
            {
                Lengte = value;
            }
        }
        public double LengteInM
        {
            get
            {
                return Lengte;
            }
        }
        public double LengteInCm
        {
            get
            {
                return Lengte * 10;
            }
        }
        public double LengteInKm
        {
            get
            {
                return Lengte / 1000;
            }
        }
        public double LengteInVoet
        {
            get
            {
                return Lengte * 3.2808;
            }
        }
    }
}
