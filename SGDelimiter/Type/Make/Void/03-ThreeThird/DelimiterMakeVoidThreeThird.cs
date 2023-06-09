using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static void MakeThreeThirdVoid(List<SGSymbol> list_DELIMITER, List<SGSymbol> list_DELIMITER__REPRESENTATION)
        {
            foreach (SGSymbol symbol in list_DELIMITER)
            {
                var safe_ONE__FIRST = (symbol.Value.Length == 1) is true;

                if (safe_ONE__FIRST is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var character = symbol.Value[0];

                var integer = (Int32)character;

                var symbol_REPRESENT = integer.ToString();

                var symbol_CAST = SGSymbol.Runtime_MakeSymbolNew(symbol_REPRESENT);

                list_DELIMITER__REPRESENTATION.Add(symbol_CAST);

                continue;
            }

            return;
        }
    }
}
