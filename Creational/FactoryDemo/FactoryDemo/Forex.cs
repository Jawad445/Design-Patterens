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
        IProcessor processor = ProcessorFactory.GetProcessor(_exchange.Name, _exchange.Volume_1day_usd);
        
        return processor.Predict();
    }
}
