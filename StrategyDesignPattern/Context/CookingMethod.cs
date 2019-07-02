using System;

namespace StrategyDesignPattern
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    public class CookingMethod
    {
        private string Food;
        private ICookStrategy _cookStrategy;

        public void SetCookStrategy(ICookStrategy cookStrategy)
        {
            _cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
