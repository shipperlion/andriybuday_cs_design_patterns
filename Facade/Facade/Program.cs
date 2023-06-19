using Facade;

SkiResortFacade skiResortFacade = new SkiResortFacade();
int height = 180, weight = 90, feetSize = 45, skierLevel = 2, roomQuality = 3;
int totalPrice = skiResortFacade.HaveGoodRest(height, weight, feetSize, skierLevel, roomQuality);
Console.WriteLine($"Total price is {totalPrice}$");

