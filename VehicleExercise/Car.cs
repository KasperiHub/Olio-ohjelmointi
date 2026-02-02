internal class Car : Vehicle
{
    public string type;

    public Car(string brand, string model, string modelYear, double price, string type)
        : base(brand, model, modelYear, price)
    {
        this.type = type;
    }

    public Car()
    {
        this.type = string.Empty;
    }

    public override string ToString()
    {
        return base.ToString() +
               $"Type: {type}\n";
    }

    public override bool Equals(object? obj)
    {
        return obj is Car car &&
               brand == car.brand &&
               model == car.model &&
               modelYear == car.modelYear;
    }
}
