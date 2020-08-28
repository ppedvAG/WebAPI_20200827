using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Good
{
    public interface ICar
    {
        string Brand { get; set; }
        
        string Type { get; set; }

        DateTime Baujahr { get; set; }
    }
}
