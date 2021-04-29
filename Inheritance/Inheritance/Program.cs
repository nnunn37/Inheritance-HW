using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            Shine Gloss = new Shine();
            Gloss.Name = "Hellcat";
            Maker r1 = new Maker();
            r1.Shine = Gloss;
            r1.Brand = Ford;
            r1.Speed = Hyper;

            Shine Bland = new Shine();
            Bland.Name = "Ugly";
            Maker r2 = new Maker();
            r2.Shine = Bland;
            r2.Brand = Dodge;
            r2.Speed = Slow;

            Shine Decent = new Shine();
            Decent.Name = "Daily";
            Maker r3 = new Maker();
            r3.Shine = Decent;
            r3.Brand = Chevy;
            r3.Speed = medium;

            Shine Fancy = new Shine();
            Fancy.Name = "Hellcat";
            Maker r4 = new Maker();
            r4.Shine = Fancy;
            r4.Brand = GMC;
            r4.Speed = Fast;

        }
    }
}
