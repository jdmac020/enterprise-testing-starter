using System;

namespace Core.Utilities
{
    /// <summary>
    /// Wrapper around System.Random -- do not test external dependency libraries, test how your code reacts to them
    /// </summary>
    public class NumberGenerator
    {
        private readonly Random _generator;
        private readonly int _floor;
        private readonly int _ceiling;

        public NumberGenerator(int floor, int ceiling)
        {
            _generator = new Random();
            _floor = floor;
            _ceiling = ceiling;
        }

        /// <summary>
        /// Returns an int within the NumberGenerator's established floor and ceiling values.
        /// </summary>
        public int GetNumber()
        {
            return _generator.Next(_floor, _ceiling);
        }
    }
}
