using State;

Product beer = new Product();
beer.Name = "MyBestBeer";
beer.Price = 78000;

Order order = new Order();
order.WriteCurrentStateName();

order.AddProduct(beer);
order.WriteCurrentStateName();

order.Register();
order.WriteCurrentStateName();

order.Grant();
order.WriteCurrentStateName();

order.Ship();
order.WriteCurrentStateName();

order.AddProduct(beer);
order.WriteCurrentStateName();


