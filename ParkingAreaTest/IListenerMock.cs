using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{
    interface IListenerMock
    {
        void RiceveMacchina(string targa, DateTime orarioEntrata);

        decimal UscitaECosto(string targa, DateTime orarioUscita);

        void Pagamento(decimal Money, string targa);

        event Action<MockUscita> NowPaid;
    }
}
