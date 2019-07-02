using System;

namespace StrategyDesignPattern
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class OvenBaking : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }
}
