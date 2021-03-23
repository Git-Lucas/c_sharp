using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesStore.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
