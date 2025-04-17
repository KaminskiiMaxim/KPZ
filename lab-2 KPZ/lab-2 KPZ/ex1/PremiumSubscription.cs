using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee => 14.99m;
        public int MinPeriodMonths => 1;
        public string[] Channels => new[] { "All Channels", "4K Content", "Live Concerts" };
    }
}
