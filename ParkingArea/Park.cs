using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    class Park
    {
        public Park()
        {
            PostiDisponibili = 200;
            TariffaOraria = 0.80M;
            OrarioAperture = new DateTime(2018, 6, 14, 8, 0, 1);
            OrarioChiusura = new DateTime(2018, 6, 14, 19, 59, 59);
        }

        public int PostiDisponibili { get; set; }
        public decimal TariffaOraria { get; set; }
        public DateTime OrarioAperture { get; set; }
        public DateTime OrarioChiusura { get; set; }
    }
}
