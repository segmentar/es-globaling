using Core;

namespace Core.Shared
{
    using System;

    public partial class SymbolSimple
    {
        public static implicit operator SGSymbol(SymbolSimple symbolSimple)
        {
            SGSymbol symbolResult;

            symbolResult = symbolSimple.Simple;

            return symbolResult;
        }
    }
}
