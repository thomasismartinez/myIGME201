using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class CupOfCoffee : HotDrink , ITakeOrder
    {
        public string beanType;

        public override void Steam() { }
        public void TakeOrder() { }

        public CupOfCoffee(string brand) : base(brand) { }
    }
}
