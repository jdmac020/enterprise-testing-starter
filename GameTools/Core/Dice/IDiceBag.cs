using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dice
{
    /// <summary>
    /// Collection of dice for easy rolling
    /// </summary>
    public interface IDiceBag
    {
        /// <summary>
        /// Returns the result for a D4 roll
        /// </summary>
        int D4();

        /// <summary>
        /// Returns the result for a D6 roll
        /// </summary>
        int D6();

        /// <summary>
        /// Returns the result for a D8 roll
        /// </summary>
        int D8();

        /// <summary>
        /// Returns the result for a D10 roll
        /// </summary>
        int D10();

        /// <summary>
        /// Returns the result for a D12 roll
        /// </summary>
        int D12();

        /// <summary>
        /// Returns the result for a D20 roll
        /// </summary>
        int D20();
    }
}
