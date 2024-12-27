namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car()
            {
                Make = "BMW",
                Model = "M4",
                Year = 2021

            };
            
            Console.WriteLine(NewCar.Make);
            Console.WriteLine(NewCar.Model);
            Console.WriteLine(NewCar.Year);
        }
    }
}
