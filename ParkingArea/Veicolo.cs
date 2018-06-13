using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    class Veicolo
    {

        public string Targa { get; set; }
        public DateTime OrarioEntrata { get; set; }
        public DateTime OrarioUscita { get; set; }
        public decimal Tariffa { get; set; }
    }
}
