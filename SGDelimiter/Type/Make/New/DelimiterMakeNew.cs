using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static SGDelimiter MakeDelimiterNew(Boolean whitespace, Boolean invisible, String[] array_SYMBOL_DELIMITER, Boolean debug)
        {
            SGDelimiter delimiterResult = default;

            var match_ONE__FIRST = (array_SYMBOL_DELIMITER == default) is true;

            if (match_ONE__FIRST is true)
            {
                array_SYMBOL_DELIMITER = new String[0];
            }
            else
                "false".ToString();

            var list_DELIMITER = new List<SGSymbol>();

            var list_DELIMITER__REPRESENTATION = new List<SGSymbol>();

            MakeOneFirstVoid(whitespace, invisible, list_DELIMITER);

            MakeTwoSecondVoid(array_SYMBOL_DELIMITER, list_DELIMITER);

            MakeThreeThirdVoid(list_DELIMITER, list_DELIMITER__REPRESENTATION);

            delimiterResult = new SGDelimiter(whitespace, invisible, list_DELIMITER, list_DELIMITER__REPRESENTATION, debug);

            return delimiterResult;
        }
    }
}
