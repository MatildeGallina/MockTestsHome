using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingArea
{
    interface IListener
    {
        void RiceveMacchina(string targa, DateTime orarioEntrata);

        decimal UscitaECosto(string targa, DateTime orarioUscita);

        void Pagamento(decimal Money, string targa);

        event Action<Uscita> NowPaid;
    }
}
