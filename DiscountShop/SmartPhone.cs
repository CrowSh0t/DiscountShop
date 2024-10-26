using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountShop
{
    public class SmartPhone: Publisher
    {
        public void DiscountForSmartPhone()
        {
            for (int i = 0; i < Subscribers.Count; i++)
            {
                Subscribers[i].Update(45);
            }
        }
    }
}
