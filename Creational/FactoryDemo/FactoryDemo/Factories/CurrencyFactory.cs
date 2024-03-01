using FactoryDemo.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.Factories;

public class CurrencyFactory : ProcessFactory
{
    public override double CalculateIntrest()
    {
        throw new NotImplementedException();
    }

    public override IProcessor CreateProcess(string exchangeName, float volume)
    {
        throw new NotImplementedException();
    }
}
