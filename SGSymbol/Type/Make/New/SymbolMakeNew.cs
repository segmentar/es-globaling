using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public static SGSymbol MakeSymbolNew(String value, Boolean debug)
        {
            SGSymbol symbolResult = default;

            symbolResult = new SGSymbol(value, debug);

            return symbolResult;
        }
    }
}
