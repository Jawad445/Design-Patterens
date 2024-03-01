using FactoryDemo.Models;
using FactoryDemo.Processors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.Factories
{
    public class CryptoCurrencyFactory : ProcessFactory
    {
        public override double CalculateIntrest()
        {
            return 100;
        }

        public override IProcessor CreateProcess(string exchangeName, float volume)
        {
            IProcessor processor = null;
            if (exchangeName == "BTC")
            {
                processor = new BitcoinProcessor(Risk.High, volume);
            }
            else if (exchangeName == "ETH")
            {
                processor = new BitcoinProcessor(Risk.High, volume);
            }
            else
            {
                throw new NotImplementedException("Exchange Not Found");
            }
            return processor;
        }
    }
}
