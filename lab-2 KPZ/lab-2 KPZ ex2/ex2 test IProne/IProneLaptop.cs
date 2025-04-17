using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ_ex2
{
    public class IProneLaptop : ILaptop
    {
        public void Specs()
        {
            Console.WriteLine("IProne Laptop: потужний процесор, Retina дисплей");
        }
    }
}
