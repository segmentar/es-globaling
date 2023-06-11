using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public static SGSymbol MakeSymbolNew(String value, Boolean debug)
        {
            SGSymbol symbolResult = default;

            var match__ONE_FIRST = (value == default) is true;

            if (match__ONE_FIRST is true)
            {
                value = null;
            }
            else
                "false".ToString();

            symbolResult = new SGSymbol(value, debug);

            return symbolResult;
        }
    }
}
