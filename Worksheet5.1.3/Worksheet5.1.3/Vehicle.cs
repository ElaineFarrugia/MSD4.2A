using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Worksheet5._1._3
{
    public class Vehicle
    {
        //variables
        public string Vin;
        public string Make;
        public string Model;
        public int Weight;
        public double FuelCons;
        public double FuelCapacity;
        public double FuelLevel;
        
        public Vehicle() { } //parameter-less

        //parametrised
        public Vehicle(string _Vin,
                       string _Make,
                       string _Model,
                       int _Weight,
                       double _FuelCons,
                       double _FuelCapacity)
        {
            Vin = _Vin;
            Make = _Make;
            Model = _Model;
            Weight = _Weight;
            FuelCons = _FuelCons;
            FuelCapacity = _FuelCapacity;
            FuelLevel = _FuelCapacity / 2;
        }

        public string GetData()
        {
            return "Vin: " + Vin +
                   "\nMake: " + Make +
                   "\nModel: " + Model +
                   "\nWeight: " + Weight +
                   "\nFuel Consumption: " + FuelCons +
                   "\nFuel Capacity: " + FuelCapacity +
                   "\nFuel Level: " + FuelLevel;
        }

        public void FillUpFuelTank()
        {
            FuelLevel = FuelCapacity;
        }

        public bool MakeTrip(string destination)
        {
            double RequiredFuel = 0;

            if (destination == "Valletta")
                RequiredFuel = 8 / 100 * FuelCons;

            else if (destination == "Sliema")
                RequiredFuel = 10 / 100 * FuelCons;

            else if (destination == "Bugibba")
                RequiredFuel = 19 / 100 * FuelCons;

            if (FuelLevel > RequiredFuel) //WE HAVE ENOUGH FUEL!
            {
                FuelLevel -= RequiredFuel;
                return true;                                
            }
            else //WE DON'T HAVE ENOUGH FUEL
            {
                return false;
            }
        }
    }
}
