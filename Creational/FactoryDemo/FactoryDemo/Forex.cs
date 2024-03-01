using FactoryDemo.Models;
using FactoryDemo.Processors;

namespace FactoryDemo;

public class Forex
{
    private Exchange _exchange;
    public Forex(Exchange exchange)
    {
        _exchange = exchange;
    }

    public List<double> GetForcastData()
    {
        IProcessor processor = null;
        if (_exchange.Name == "BTC")
        {
            processor = new BitcoinProcessor(Risk.High, _exchange.Volume_1day_usd);
        }
        else if (_exchange.Name == "ETH")
        {
            processor = new BitcoinProcessor(Risk.High, _exchange.Volume_1day_usd);
        }
        else
        {
            processor = new BitcoinProcessor(Risk.Low, _exchange.Volume_1hrs_usd);
        }
        return processor.Predict();
    }
}
