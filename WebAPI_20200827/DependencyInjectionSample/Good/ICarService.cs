﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Good
{
    public interface ICarService
    {
        void RepairCar(ICar car);
    }
}
