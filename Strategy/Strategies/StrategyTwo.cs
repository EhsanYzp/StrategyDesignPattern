using Interfaces;
using System;

namespace Strategy.Strategies
{
    public class StrategyTwo : IStrategies
    {
        public void Action(string context)
        {
            Console.WriteLine($"Strategy Two: {context}");
        }
    }
}
