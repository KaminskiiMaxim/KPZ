using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_KPZ
{
    public class Money
    {
        public int Units { get; set; }      // гривні
        public int Cents { get; set; }      // копійки

        public Money(int units, int cents)
        {
            Units = units;
            Cents = cents;
        }

        public void SetMoney(int units, int cents)
        {
            Units = units;
            Cents = cents;
        }

        public void Show()
        {
            Console.WriteLine($"{Units}.{Cents:D2} грн");
        }
    }
}
