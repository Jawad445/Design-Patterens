using FactoryDemo.Models;
using FactoryDemo.Processors;

namespace FactoryDemo.Factories;

public abstract class ProcessFactory
{
    public abstract IProcessor CreateProcess(string exchangeName, float volume);
    public abstract double CalculateIntrest();

    public IProcessor GetProcessor(string exchangeName, float volume)
    {
        var processor = CreateProcess(exchangeName, volume);
        if(CalculateIntrest() < 199)
        {
            processor.risk = Risk.Low;
        }
        return processor;
    }
}
