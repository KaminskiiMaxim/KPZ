using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriodMonths { get; }
        string[] Channels { get; }
    }

}
