using Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Strategy.Context
{
    /// <summary>
    /// Example Class in which we want to use strategy pattern to remove switch cases
    /// </summary>
    public class ExampleContextClass
    {
        /// <summary>
        /// The method with switch cases
        /// </summary>
        /// <param name="type">strategy name in string</param>
        /// <param name="context">parameter to pass to strategy(for test)</param>
        /// <returns></returns>
        public bool SwitchCaseMethod(String type, String context)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();

                var strategyClassName = assembly.GetTypes()
                    .First(t => t.Name == type);

                IStrategies strategy = (IStrategies)Activator.CreateInstance(strategyClassName);
                strategy.Action(context);
                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine($"Error: {err}");
                return false;
            }
        }
    }
}

