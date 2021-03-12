using System;
using Strategy.Context;

namespace Strategy
{
    /// <summary>
    /// Entry point to the project
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Example parameter to pass to strategies. 
            String context = "Sample Message transmitting to the strategy class";

            //Name of strategy we want to invoke
            //This could be generated runtime in code
            String strategyClassName = "StrategyOne";

            //Class using which we use reflection to invoke different strategies
            ExampleContextClass contextClass = new ExampleContextClass();

            //we just pass the name of the strategy(e.g: StrategyOne) to the context method (SwitchCaseMethod)
            //and it automatically binds it to a strategy.
            contextClass.SwitchCaseMethod(strategyClassName, context);
          
            Console.ReadKey();
        }
    }
}
