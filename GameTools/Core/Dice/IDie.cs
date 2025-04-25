using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dice
{
    /// <summary>
    /// Handles random number generation within a set range
    /// </summary>
    public interface IDie
    {
        int Roll();
    }
}
