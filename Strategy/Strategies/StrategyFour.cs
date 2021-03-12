using Interfaces;
using System;

namespace Strategy.Strategies
{
    public class StrategyFour : IStrategies
    {
        public void Action(string context)
        {
            Console.WriteLine($"Strategy Four: {context}");
        }
    }
}
