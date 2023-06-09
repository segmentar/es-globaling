using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public static SGSymbol Runtime_MakeSymbolNew(String value)
        {
            SGSymbol symbolResult = default;

            symbolResult = MakeSymbolNew(value, SAPolicy.SymbolDebugPolicy);

            return symbolResult;
        }
    }
}
