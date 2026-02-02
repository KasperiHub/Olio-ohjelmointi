internal class Car : Vehicle
{
    public string type;
    public string  engine; 
    public double  doors;

    public Car(string brand, string model, string modelYear, double price, string type, string engine, double doors) : base(brand, model, modelYear, price)
    {
        this.type = type;
        this.engine = engine;
        this.doors = doors;
    }

    public Car()
    {
        this.type = string.Empty;
        this.engine = string.Empty;
        this.doors = 0;
    }

    public override string ToString()
    {
        return base.ToString() +
               $"Type: {type}\n" +
               $"Engine: {engine}\n" +
               $"Doors: {doors}\n";
    }

    public override bool Equals(object? obj)
    {
        return obj is Car car &&
               brand == car.brand &&
               model == car.model &&
               modelYear == car.modelYear;
    }
}
