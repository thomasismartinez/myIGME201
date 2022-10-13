using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class Waiter : IMood
    {
        public string name;

        private string mood;
        public string Mood
        {
            get { return mood; }
        }

        public void ServerCustomer(HotDrink cup) { }
    }
}
