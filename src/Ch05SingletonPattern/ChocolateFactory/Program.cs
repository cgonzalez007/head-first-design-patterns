using ChocolateFactory;

var boiler = ChocolateBoiler.GetInstance();

boiler.Fill();
boiler.Boil();
boiler.Drain();

