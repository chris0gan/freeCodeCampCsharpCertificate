decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saves {0:C2} off the regualr {1:C2} price.", price - salePrice, price);

Console.WriteLine(yourDiscount);