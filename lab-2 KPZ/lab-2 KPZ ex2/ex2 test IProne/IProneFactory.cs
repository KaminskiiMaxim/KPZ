using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2_KPZ;

namespace lab_2_KPZ_ex2
{
    public class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook();
        }

        public IEBook CreateEBook()
        {
            return new IProneEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }   
}
