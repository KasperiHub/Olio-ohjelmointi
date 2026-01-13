namespace CarExercis
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car yourCar = new Car();
            myCar.AskData();
            yourCar.AskData();
            myCar.ShowCarinfo();
            yourCar.ShowCarinfo();
            myCar.Accelerate(-50);
            myCar.ShowCarinfo();
            myCar.Brake();
            myCar.ShowCarinfo();
               
        }
    }
}
