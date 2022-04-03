public static class Starter
{
    public static void Run()
    {
        TaxiDepot depot = new TaxiDepot();
        var taxiDepot = new TaxiDepotFactory();
        taxiDepot.OrderComfortCar(depot.ComfortCars);
        taxiDepot.OrderStandartCar(depot.StandartCars);
        taxiDepot.OrderMinibus(depot.Minibus);
        foreach (var item in depot.ComfortCars)
        {
            Console.WriteLine($"Comfort car: {item.Name}, Consumption: {item.Consumption}");
        }

        foreach (var item in depot.StandartCars)
        {
            Console.WriteLine($"Standart car: {item.Name}, Consumption: {item.Consumption}");
        }

        foreach (var item in depot.Minibus)
        {
            Console.WriteLine($"Minibus: {item.Name}, Consumption: {item.Consumption}");
        }

        Console.WriteLine($"Total price of depot: {depot.StandartCarsPrice() + depot.ComfortCarsPrice() + depot.MinibusesPrice()}$ ");
    }
}