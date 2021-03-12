using Interfaces;
using System;

namespace Strategy.Strategies
{
    public class StrategyThree : IStrategies
    {
        public void Action(string context)
        {
            Console.WriteLine($"Strategy Three: {context}");
        }
    }
}
