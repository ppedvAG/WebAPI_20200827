using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Good
{
    public class Car : ICar
    {
        public string Brand { get; set ; }
        public string Type { get ; set ; }
        public DateTime Baujahr { get; set; }
    }
}
