using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_TESTING
{
    internal class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double totalCost()
            {
                return unitCost * unitCount;
            }
            public FormattableString orderPrint()
            {
                FormattableString orderString =
                    $"{unitCount} {itemName} items at ${unitCost} each, total cost ${totalCost()}";
                return orderString;
            }
        }
        static void Main(string[] args)
        {
            order O = new order();
            O.itemName = "Computer";
            O.unitCost = 20;
            O.unitCount = 5;

            Console.WriteLine(O.orderPrint());
        }
    }
}
