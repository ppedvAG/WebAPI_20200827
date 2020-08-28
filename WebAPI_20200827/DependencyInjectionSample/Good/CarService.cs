using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Good
{
    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            //Tuh was
        }
    }

    public class MockCarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            Console.WriteLine(car.Brand + "wird pseudomäßig repariert");
        }
    }

    //Mock-Car
    public class MockCar : ICar
    {
        public string Brand
        {
            get;
            set;
        } = "BMW";

        public string Type { get; set; } = "3er";
        public DateTime Baujahr { get; set; } = DateTime.Now;
    }
}
