using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class CupOfCocoa : HotDrink , ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            set { this.source = value; }
        }
        public override void Steam() { }
        public override void AddSugar(byte amount) { }
        public void TakeOrder() { }

        public CupOfCocoa(): this(false) { }
        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand") { }
    }
}
