using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee => 5.99m;
        public int MinPeriodMonths => 1;
        public string[] Channels => new[] { "News", "Movies", "Sports" };
    }

}
