using DiscountShop;
ConcreteSubscribers Sub1 = new ConcreteSubscribers();
ConcreteSubscribers Sub2 = new ConcreteSubscribers();
Sub1.Discount = 20;
Sub2.Discount = 10;
Publisher publisher = new Publisher();
publisher.AddSubscribe(Sub1);
publisher.AddSubscribe(Sub2);
publisher.NotifySubscribers();
