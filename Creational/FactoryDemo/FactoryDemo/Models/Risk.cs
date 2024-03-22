using System;

namespace FactoryDemo.Models;

public enum Risk
{
    High,
    Low,
    Medium
}

public class RiskModel
{
    public Risk Risk { get; set; }
}
