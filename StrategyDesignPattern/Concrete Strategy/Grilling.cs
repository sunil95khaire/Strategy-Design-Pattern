using System;

namespace StrategyDesignPattern
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    public class Grilling : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }
}
