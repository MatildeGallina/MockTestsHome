using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    class Ingresso : Park
    {
        public Ingresso(int postiDisponibili, DateTime orarioAperture, DateTime orarioChiusura)
            : base()
        {
            listeners = new List<IListener>();
        }

        public readonly List<IListener> listeners;

        public void AggiungiUscite(IListener l)
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
                foreach (IListener l in listeners)
                    l.RiceveMacchina(targa, orario);

                PostiDisponibili--;
            }

            else
                accesso = false;

            return accesso;
        }
    }
}
