using System;

namespace FactoryDemo.Models;

public class Exchange
{
    public string ExchangeId { get; set; }
    public string Website { get; set; }
    public string Name { get; set; }
    public string Data_start { get; set; }
    public string Data_end { get; set; }
    public DateTime Data_quote_start { get; set; }
    public DateTime Data_quote_end { get; set; }
    public DateTime Data_orderbook_start { get; set; }
    public DateTime Data_orderbook_end { get; set; }
    public DateTime Data_trade_start { get; set; }
    public DateTime Data_trade_end { get; set; }
    public int Data_symbols_count { get; set; }
    public float Volume_1hrs_usd { get; set; }
    public float Volume_1day_usd { get; set; }
    public float Volume_1mnth_usd { get; set; }

}
