public interface IVehicleFactory
{
    String EngineType();
    int NumberOfWheels();
}

public class Car : IVehicleFactory
{

    public String EngineType()
    {
        return "petrol";
    }

    public int NumberOfWheels()
    {
        return 4;
    }


}

public class Truck : IVehicleFactory
{

    public String EngineType()
    {
        return "desiel";
    }

    public int NumberOfWheels()
    {
        return 6;
    }


}

public class MotorCycle : IVehicleFactory
{

    public String EngineType()
    {
        return "petrol";
    }

    public int NumberOfWheels()
    {
        return 2;
    }




}

class Program
{
    public static void Main()
    {

        string VehicleType = "MotorCycle";



        if (VehicleType == "Car")
        {
            IVehicleFactory vehicle = new Car();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Types of engine   : " + vehicle.EngineType());
            Console.WriteLine("Number of Wheels  : " + vehicle.NumberOfWheels());
            Console.WriteLine("--------------------------------------------------");


        }
        else if (VehicleType == "truck")
        {


            IVehicleFactory vehicle = new Truck();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Types of engine   : " + vehicle.EngineType());
            Console.WriteLine("Number of Wheels  : " + vehicle.NumberOfWheels());
            Console.WriteLine("--------------------------------------------------");

        }
        else if (VehicleType == "MotorCycle")
        {
            int SeatNumber = 2;
            IVehicleFactory vehicle = new MotorCycle();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Types of engine   : " + vehicle.EngineType());
            Console.WriteLine("Number of Wheels  : " + vehicle.NumberOfWheels());
            Console.WriteLine("Number of Seat    : " + SeatNumber);
            Console.WriteLine("--------------------------------------------------");
        }
        else
        {
            Console.WriteLine("error");

        }






    }




}


