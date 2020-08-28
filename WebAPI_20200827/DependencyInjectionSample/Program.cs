using DependencyInjectionSample.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarService();

            ICarService mockCarService = new MockCarService();
            mockCarService.RepairCar(new Car());

            carService.RepairCar(new MockCar());

            carService.RepairCar(new Car());

        }
    }


}
