// Code 2-18, 2-19
using System;
using System.IO;
using System.Collections.Generic;

using SalesCalculator;

SalesCounter sales = new SalesCounter(SalesCounter.ReadSales("Sales.csv"));
Dictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
foreach (KeyValuePair<string, int> obj in amountsPerStore)
{
    Console.WriteLine($"{obj.Key} {obj.Value}");
}

