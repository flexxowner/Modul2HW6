public class TaxiDepot : ITaxiDepot
{
    public ComfortCars[] ComfortCars = new ComfortCars[2];
    public StandartCars[] StandartCars = new StandartCars[2];
    public Minibus[] Minibus = new Minibus[2];

    public int ComfortCarsPrice()
    {
        int totalPrice = 0;
        for (int i = 0; i < ComfortCars.Length; i++)
        {
            totalPrice += StandartCars[i].Price;
        }

        return totalPrice;
    }

    public int MinibusesPrice()
    {
        int totalPrice = 0;

        for (int i = 0; i < Minibus.Length; i++)
        {
            totalPrice += Minibus[i].Price;
        }

        return totalPrice;
    }

    public int StandartCarsPrice()
    {
        int totalPrice = 0;

        for (int i = 0; i < StandartCars.Length; i++)
        {
            totalPrice += StandartCars[i].Price;
        }

        return totalPrice;
    }
}
