using DiscountShop;
ConcreteSubscribers Sub1 = new ConcreteSubscribers();
ConcreteSubscribers Sub2 = new ConcreteSubscribers();
Sub1.Discount = 20;
Sub2.Discount = 10;
LapTop lapTop = new LapTop();
lapTop.AddSubscribe(Sub1);
lapTop.DiscountForLapTop();