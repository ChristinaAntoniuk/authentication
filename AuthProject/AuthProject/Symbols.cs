using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthProject
{
    /// <summary>
    /// Class is used for storing a set of characters which are needed for string's trim.
    /// </summary>
    public abstract class Symbols
    {
        protected static char[] SYMBOLS = { '\n', '\r', ' ', '-' };

    }
}
