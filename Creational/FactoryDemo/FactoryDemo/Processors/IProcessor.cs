using FactoryDemo.Models;
using System;
namespace FactoryDemo.Processors;

public interface IProcessor
{
    public List<double> Predict();
    Risk risk {  get; set; }
}
