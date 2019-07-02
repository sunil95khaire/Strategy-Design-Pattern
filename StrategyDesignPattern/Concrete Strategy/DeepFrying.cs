using System;

namespace StrategyDesignPattern
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class DeepFrying : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }
}
