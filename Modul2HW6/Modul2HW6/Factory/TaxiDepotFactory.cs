public class TaxiDepotFactory : Taxi
{
    public override ComfortCars[] OrderComfortCar(ComfortCars[] cars)
    {
        cars[0] = new BMW("X5", 70000, 8.7);
        cars[1] = new BMW("320", 14300, 9.7);

        return cars;
    }

    public override StandartCars[] OrderStandartCar(StandartCars[] cars)
    {
        cars[0] = new Hyundai("Elantra", 30000, 6.7);
        cars[1] = new Hyundai("Coupe", 20000, 7.8);
        return cars;
    }

    public override Minibus[] OrderMinibus(Minibus[] minibus)
    {
        minibus[0] = new Volkswagen("T5", 40000, 10.5);
        minibus[1] = new Volkswagen("T4", 15000, 11.5);
        return minibus;
    }
}
