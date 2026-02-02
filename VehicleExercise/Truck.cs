internal class Truck : Car
{
    public string load;
    public double consumption;

    public Truck(string brand, string model, string modelYear, double price,
                 string type, string load, double consumption)
        : base(brand, model, modelYear, price, type)
    {
        this.load = load;
        this.consumption = consumption;
    }

    public Truck()
    {
        this.load = string.Empty;
        this.consumption = 0;
    }

    public double CalculateConsumption(double distance)
    {
        return consumption * (distance / 100);
    }

    public override string ToString()
    {
        return base.ToString() +
               $"Load: {load}\n" +
               $"Consumption: 100 Kilometrin matkalle tarvii polttoainetta: {CalculateConsumption(100)}L\n";
    }
}
