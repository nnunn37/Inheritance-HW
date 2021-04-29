using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Maker
    {
        private string _Brand;
        private Speed _Speed;
        private Shine _Shine;
        private Release _Release;
        private ReleaseType _ReleaseType;

        public string Brand { get => _Brand; set => _Brand = value; }
        internal Shine Shine { get => _Shine; set => _Shine = value; }
        internal Speed Speed { get => _Speed; set => _Speed = value; }
        internal Release Release { get => _Release; set => _Release = value; }
        internal ReleaseType ReleaseType { get => _ReleaseType; set => _ReleaseType = value; }
    }
}
