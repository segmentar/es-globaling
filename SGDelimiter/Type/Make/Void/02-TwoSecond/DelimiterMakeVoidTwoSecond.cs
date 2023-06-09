using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static void MakeTwoSecondVoid(String[] array_SYMBOL_DELIMITER, List<SGSymbol> list_DELIMITER)
        {
            foreach (String symbol_DELIMITER in array_SYMBOL_DELIMITER)
            {
                var symbol = SGSymbol.Runtime_MakeSymbolNew(symbol_DELIMITER);

                list_DELIMITER.Add(symbol);

                continue;
            }

            return;
        }
    }
}
