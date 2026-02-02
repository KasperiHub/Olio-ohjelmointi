internal abstract class Vehicle
{
    public string brand;
    public string model;
    public string modelYear;
    public double price;

    public Vehicle(string brand, string model, string modelYear, double price)
    {
        this.brand = brand;
        this.model = model;
        this.modelYear = modelYear;
        this.price = price;
    }

    public Vehicle()
    {
        this.brand = string.Empty;
        this.model = string.Empty;
        this.modelYear = string.Empty;
        this.price = 0;
    }

    public override string ToString()
    {
        return
            $"Brand: {brand}\n" +
            $"Model: {model}\n" +
            $"Model year: {modelYear}\n" +
            $"Price: {price}\n";
    }
        public virtual string PrintInformation()
        {
        return 
            $"Brand: {brand}\n" +
            $"Model: {model}\n" +
            $"ModelYear: {modelYear}\n" +
            $"Price: {price}\n";
    }
    
}
