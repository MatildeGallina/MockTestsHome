using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    class Sbarra
    {
        public Sbarra()
        {
            Open = false;
        }

        public bool Open { get; set; }

        public event Action<Sbarra> ChiusuraSbarra;

        public void CarTriesToPass(string targa)
        {
            if (Open is false)
            {
                Open = true;
            }
            else
                throw new ArgumentException();
        }

        public void VeicoloUscito(Sbarra s)
        {
            if (Open == true)
                Open = false;
        }
    }
}
