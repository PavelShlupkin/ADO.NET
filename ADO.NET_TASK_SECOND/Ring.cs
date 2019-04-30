using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    public class Ring
    {
        private Circle circleOut;
        private Circle circleIn;

        public Circle CircleOut
        {
            get
            {
                return circleOut;
            }
            set
            {
                if (value.R > 0)
                {
                    circleOut = value;
                }
                else
                {
                    throw new ArgumentException("Error radius");
                }
            }
        }
        public Circle CircleIn
        {
            get
            {
                return circleIn;
            }
            set
            {
                if (value.R > 0)
                {
                    circleIn = value;
                }
                else
                {
                    throw new ArgumentException("Error radius");
                }
            }
        }

        public Ring(Circle circleOut, Circle circleIn)
        {
            if (circleIn.R >= circleOut.R)
            {
                throw new ArgumentException("Invalid Ring!");
            }
            CircleOut = circleOut;
            CircleIn = circleIn;
        }
        public double LengthR
        {
            get
            {
                return LengthInR + LengthOutR;
            }
        }
        private double LengthOutR
        {
            get
            {
                return (2 * Math.PI * circleOut.R);
            }
        }
        private double LengthInR
        {
            get
            {
                return (2 * Math.PI * circleIn.R);
            }
        }
        public double S
        {
            get
            {
                return (Math.PI * (circleOut.R * circleOut.R - circleIn.R * circleIn.R));
            }
        }
        public string ShowRing()
        {
            return ($"Center:{circleOut.X}{circleOut.Y}, Outher radius: {circleOut.R}, Inner radius: {circleIn.R}");
        }
    }
}
