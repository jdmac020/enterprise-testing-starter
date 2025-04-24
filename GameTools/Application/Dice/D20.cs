using Core.Dice;
using Core.Utilities;
using System;

namespace Application.Dice
{
    /// <summary>
    /// Second system under test (SUT) to introduce mocking
    /// </summary>
    public class D20 : IDie
    {
        private readonly INumberGenerator _generator;

        public D20(INumberGenerator generator)
        {
            _generator = generator;
        }

        public int Roll()
        {
            throw new NotImplementedException();
        }
    }
}
