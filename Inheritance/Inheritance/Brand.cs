using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    enum CarType
    {
        Ford,
        Dodge,
        GMC,
        Chevy
    }
    class Brand
    {
        public string CarName;
        public CarType thisCarType;
    }
}
