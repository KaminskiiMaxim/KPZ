using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    public class WebSiteCreator : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new DomesticSubscription(); // або інше
        }
    }
}
