using FactoryDemo.Factories;
using FactoryDemo.Models;
using FactoryDemo.Processors;

namespace FactoryDemo;

public class Forex
{
    private Exchange _exchange;
    private ProcessFactory _factory;
    public Forex(Exchange exchange, ProcessFactory factory)
    {
        _exchange = exchange;
        _factory = factory;
    }

    public List<double> GetForcastData()
    {
        IProcessor processor = _factory.CreateProcess(_exchange.Name, _exchange.Volume_1day_usd);
        
        return processor.Predict();
    }
}
