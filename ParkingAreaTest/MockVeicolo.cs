using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{
    class MockVeicolo
    {
        public string Targa { get; set; }
        public DateTime OrarioEntrata { get; set; }
        public DateTime OrarioUscita { get; set; }
        public decimal Tariffa { get; set; }
    }
}
