﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountShop
{
    public class Publisher
    {
        List<InterfaceSubscriber> Subscribers = new List<InterfaceSubscriber>();

        public void AddSubscribe(InterfaceSubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }
        public void UnSubcribe(InterfaceSubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }
    }
}
