using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static void MakeOneFirstVoid(Boolean whitespace, Boolean invisible, List<SGSymbol> list_DELIMITER)
        {
            if (whitespace is true)
            {
                list_DELIMITER.Add(SGSymbol.Runtime_MakeSymbolNew(SASyntax.Whitespace.ToString()));
            }
            else
                "false".ToString();

            if (invisible is true)
            {
                list_DELIMITER.Add(SGSymbol.Runtime_MakeSymbolNew(SASyntax.Tabulation.ToString()));

                list_DELIMITER.Add(SGSymbol.Runtime_MakeSymbolNew(SASyntax.CarriageReturn.ToString()));

                list_DELIMITER.Add(SGSymbol.Runtime_MakeSymbolNew(SASyntax.LineFeed.ToString()));
            }
            else
                "false".ToString();

            return;
        }
    }
}
