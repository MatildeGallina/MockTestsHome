using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    class Uscita : Park, IListener
    {
        public Uscita(DateTime orarioAperture, DateTime orarioChiusura)
            : base()
        {
            this.veicoli = new List<Veicolo>();
            this.Tariffa = Tariffa;
        }

        public List<Veicolo> veicoli { get; set; }
        public decimal Tariffa { get; set; }

        public event Action<Uscita> NowPaid;

        public void RiceveMacchina(string targa, DateTime orarioEntrata)
        {
            Veicolo v = new Veicolo();
            v.Targa = targa;
            v.OrarioEntrata = orarioEntrata;

            veicoli.Add(v);
        }

        public decimal UscitaECosto(string targa, DateTime orarioUscita)
        {

            foreach (Veicolo v in veicoli)
                if (targa == v.Targa)
                {
                    Tariffa = (decimal)((orarioUscita - v.OrarioEntrata).TotalHours);
                    Tariffa *= TariffaOraria;
                    v.Tariffa = Tariffa;

                    break;
                }

            else
                throw new ArgumentException();

            return Tariffa;
        }

        public void Pagamento(decimal Money, string targa)
        {
            foreach(Veicolo v in veicoli)
                if(targa == v.Targa)
                {
                    while (v.Tariffa > 0)
                        v.Tariffa -= Money;

                    Sbarra s = new Sbarra();

                    NowPaid += s.CarTriesToPass;

                    veicoli.Remove(v);
                    PostiDisponibili++;
                }
        }
    }
}
