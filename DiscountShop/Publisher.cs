﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountShop
{
    public abstract class Publisher
    {
        protected List<InterfaceSubscriber> Subscribers = new List<InterfaceSubscriber>();

        public void AddSubscribe(InterfaceSubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }
        public void UnSubcribe(InterfaceSubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }
        protected void NotifySubscribers()
        {
            for (int i = 0; i < Subscribers.Count; i++)
            {
                Subscribers[i].Update(50);
            }
        }
    }
}
