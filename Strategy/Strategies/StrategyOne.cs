using Interfaces;
using System;

namespace Strategy.Strategies
{
    public class StrategyOne : IStrategies
    {
        public void Action(string context)
        {
            Console.WriteLine($"Strategy One: {context}");
        }
    }
}


