using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{
    class MockSbarra
    {
        public MockSbarra()
        {
            Open = false;
        }

        public bool Open { get; set; }

        public event Action<MockSbarra> ChiusuraSbarra;

        public void CarTriesToPass(MockUscita s)
        {
            if (Open is false)
            {
                Open = true;

                ChiusuraSbarra += VeicoloUscito;
            }
            else
                throw new ArgumentException();
        }

        public void VeicoloUscito(MockSbarra s)
        {
            if (Open == true)
                Open = false;
        }
    }
}
