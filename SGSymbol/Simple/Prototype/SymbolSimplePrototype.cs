using Core;

namespace Core.Shared
{
    using System;

    public partial class SymbolSimple
    {
        public SymbolSimple(String value)
        {
            this.Simple = SGSymbol.Runtime_MakeSymbolNew(value);

            return;
        }
    }
}
