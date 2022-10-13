using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class CupOfTea : HotDrink , ITakeOrder
    {
        public string leafType;

        public override void Steam() { }
        public void TakeOrder() { }

        public CupOfTea(bool CustomerIsWealthy) { }
    }
}
