# StrategyDesignPattern
A simple implementation of Strategy Design Pattern in C#

The main idea behind this design pattern is to define a “global interface” and then define “multiple strategy classes” implementing the interface. The global interface will have some methods which then will be implemented by any of the strategy classes (each has its own version). Then, at runtime, using reflection, we find out the strategy we want to invoke and execute its logic!

You can use this code to:
1. replace “switch” and “case” parts of the code with strategy classes and reflection.
2. decouple the code and applying SOLID principles for better readability and testing.


The simple scenario is like this:
1. Defining a Global Interface with Generic needed method(example in code: IStrategies.cs and method Action)
2. Defining Strategy classes implementing the global interface (example in code: StrategyOne.cs, StrategyTwo.cs, StrategyThree.cs, StrategyFour.cs)
3. Defining Context class which invokes strategies using reflection (example in code: ExampleContextClass.cs)
4. Test (example in code: Program.cs)
