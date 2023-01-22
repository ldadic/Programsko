using ProgramskoInzenjerstvo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramskoInzenjerstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Station smallTrainTerminal = new Station();
            Station bigTrainTerminal = new Station();

            Employee SmallTrainEmp = new Employee("Pero", "Peric", 0.1);
            Employee BigTrainEmp = new Employee("Ana", "Anic", 0.11);


            Vehicle truck = new Vehicle(VehicleType.Truck, 2, 41);
            Vehicle car = new Vehicle(VehicleType.Car, 42, 7);
            Vehicle bus = new Vehicle(VehicleType.Bus, 60, 30);
            Vehicle van = new Vehicle(VehicleType.Van, 9, 8);

            bigTrainTerminal.LoadVehicleToTrain(bus, BigTrainEmp);
            bigTrainTerminal.LoadVehicleToTrain(truck, BigTrainEmp);


            smallTrainTerminal.LoadVehicleToTrain(car, SmallTrainEmp);
            smallTrainTerminal.LoadVehicleToTrain(van, SmallTrainEmp);

            smallTrainTerminal.GetTotalEarnedMoney();
            bigTrainTerminal.GetTotalEarnedMoney();

            Console.WriteLine();

            SmallTrainEmp.GetEmployeeMoneyMade();
            BigTrainEmp.GetEmployeeMoneyMade();

            Console.WriteLine();

            UnitTest test = new UnitTest();
            test.TestTrain();
        }
    }
}
