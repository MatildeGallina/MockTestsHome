using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{

    class MockIngresso : MockPark
    {
        public MockIngresso(int postiDisponibili, DateTime orarioAperture, DateTime orarioChiusura)
            : base()
        {
            listeners = new List<IListenerMock>();
        }

        public readonly List<IListenerMock> listeners;

        public void AggiungiUscite(IListenerMock l)
        {
            listeners.Add(l);
        }

        public bool AccettaVeicolo(string targa, DateTime orario)
        {
            bool accesso;

            if (PostiDisponibili == 0)
                throw new Exception();

            else if (orario >= OrarioAperture && orario <= OrarioChiusura)
            {
                accesso = true;
                foreach (IListenerMock l in listeners)
                    l.RiceveMacchina(targa, orario);

                PostiDisponibili--;
            }

            else
                accesso = false;

            return accesso;
        }
    }
}
