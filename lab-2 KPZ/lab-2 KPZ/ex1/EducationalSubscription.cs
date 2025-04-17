using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee => 3.99m;
        public int MinPeriodMonths => 6;
        public string[] Channels => new[] { "Education", "Documentaries", "Science" };
    }
}
