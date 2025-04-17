using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_KPZ
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void Discount(int discountUnits, int discountCents)
        {
            int totalCents = Price.Units * 100 + Price.Cents;
            int discount = discountUnits * 100 + discountCents;
            int newTotal = Math.Max(0, totalCents - discount);
            Price.Units = newTotal / 100;
            Price.Cents = newTotal % 100;
        }
    }

}
