using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{
    class MockUscita : MockPark, IListenerMock
    {
        public MockUscita(DateTime orarioAperture, DateTime orarioChiusura)
            : base()
        {
            this.veicoli = new List<MockVeicolo>();
            this.Tariffa = Tariffa;
        }

        public List<MockVeicolo> veicoli { get; set; }
        public decimal Tariffa { get; set; }

        public event Action<MockUscita> NowPaid;

        public void RiceveMacchina(string targa, DateTime orarioEntrata)
        {
            MockVeicolo v = new MockVeicolo();
            v.Targa = targa;
            v.OrarioEntrata = orarioEntrata;

            veicoli.Add(v);
        }

        public decimal UscitaECosto(string targa, DateTime orarioUscita)
        {

            foreach (MockVeicolo v in veicoli)
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
            foreach (MockVeicolo v in veicoli)
                if (targa == v.Targa)
                {
                    while (v.Tariffa > 0)
                        v.Tariffa -= Money;

                    MockSbarra s = new MockSbarra();

                    NowPaid += s.CarTriesToPass;

                    veicoli.Remove(v);
                    PostiDisponibili++;
                }
        }
    }
}
