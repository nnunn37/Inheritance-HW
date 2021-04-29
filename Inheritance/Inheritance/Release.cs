using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    enum ReleaseType
    {
        Truck,
        Sedan,
        Car,
        Van
    }

    enum Speed
    {
        Fast,
        Slow,
        Hyper,
        Medium,
    }
    class Release
    {
        public String ReleaseTitle;
        public ReleaseType thisReleaseType;
        public Speed thisSpeed;
        public Shine thisShine;
    }
}
