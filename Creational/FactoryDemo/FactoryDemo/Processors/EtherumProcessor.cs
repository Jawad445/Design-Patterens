using FactoryDemo.Models;
using System;

namespace FactoryDemo.Processors;

public class EtherumProcessor : IProcessor
{
    private float volume_1day_usd;
    public Risk risk { get; set; }
    public BitcoinProcessor(Risk risk, float volume_1day_usd)
    {
        this.volume_1day_usd = volume_1day_usd;
    }
    public List<double> Predict()
    {
        if (risk == Risk.High)
        {
            return new List<double>()
            {
                287.3,
                281.4,
                240.2,
                229.6,
                250.2,
                210.1,
                218.5
            };
        }
        else if (risk == Risk.Medium)
        {
            return new List<double>()
            {
                210.4,
                213.2,
                213.8,
                214.1,
                217.3,
                218.4,
                218.7,
                220.3
            };
        }
        else
        {
            return new List<double>()
            {
                110.4,
                113.2,
                113.8,
                114.1,
                117.3,
                118.4,
                118.7,
                120.3
            };
        }
    }
}
