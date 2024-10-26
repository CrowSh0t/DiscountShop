using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountShop
{
    public class ConcreteSubscribers : InterfaceSubscriber
    {
        public int Discount { get; set; }
        void InterfaceSubscriber.Update(int context)
        {
            Console.WriteLine($"New Discount: {Discount + context}");
        }
    }
}
