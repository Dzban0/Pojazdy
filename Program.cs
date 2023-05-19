using SampleVehicles;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            var volkswagen = new Car("Volkswagen", 4, 1000, Base.IVehicle.Fuel.Gasoline);
            volkswagen.TurnOn();
            volkswagen.ChangeSpeed(30);
            Console.WriteLine(volkswagen);

            var polonez = new Car("Polonez", 4, 1500, Base.IVehicle.Fuel.Oil);
            polonez.TurnOn();
            polonez.ChangeSpeed(130);
            polonez.ChangeSpeed(-30);
            polonez.ChangeSpeed(-100);
            polonez.TurnOff();
            Console.WriteLine(polonez);

            var tesla = new Car("Tesla", 4, 2100, Base.IVehicle.Fuel.Electricity);
            tesla.TurnOn();
            tesla.ChangeSpeed(230);
            tesla.TurnOff(); // won't work, because the vehicle is not still
            Console.WriteLine(tesla);

            var plane = new Plane("Private Plane", 6, 32100, Base.IVehicle.Fuel.LPG);
            plane.TurnOn();
            plane.ChangeSpeed(6);
            plane.GoAir();
            plane.ChangeSpeed(-plane.speed);
            Console.WriteLine(plane);

            var atv = new ATV("ATV", 10, 100, 5000, Base.IVehicle.Fuel.Electricity);
            atv.TurnOn();
            atv.ChangeSpeed(10);
            atv.GoWater();
            atv.ChangeSpeed(-atv.speed);
            atv.TurnOff();
            Console.WriteLine(atv);
        }
    }
}