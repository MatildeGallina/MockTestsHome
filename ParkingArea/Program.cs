using System;

namespace ParkingArea
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime orarioE = new DateTime(2018, 6, 14, 9, 0, 1);
            DateTime orarioU = new DateTime(2018, 6, 14, 13, 0, 1);

            Park p = new Park();
            Ingresso i = new Ingresso(p.PostiDisponibili, p.OrarioAperture, p.OrarioChiusura);
            IListener u = new Uscita(p.OrarioAperture, p.OrarioChiusura);
            Sbarra s = new Sbarra();

            i.AggiungiUscite(u);

            i.AccettaVeicolo("QWE123", orarioE);

            u.RiceveMacchina("QWE123", orarioE);

            u.UscitaECosto("QWE123", orarioU);

            u.Pagamento(0.20M, "QWE123");

            Console.Read();
        }
    }
}
