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

            var arrayList = new ArrayList(array_SYMBOL_DELIMITER);

            var list_DELIMITER = new List<SGSymbol>();

            var list_DELIMITER__REPRESENTATION = new List<SGSymbol>();

            MakeOneFirstVoid(whitespace, invisible, list_DELIMITER);

            MakeTwoSecondVoid(arrayList, list_DELIMITER);

            MakeThreeThirdVoid(list_DELIMITER, list_DELIMITER__REPRESENTATION);

            delimiterResult = new SGDelimiter(whitespace, invisible, list_DELIMITER, list_DELIMITER__REPRESENTATION, debug);

            return delimiterResult;
        }
    }
}

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static SGDelimiter MakeDelimiterNew(Boolean whitespace, Boolean invisible, SGText text, String[] array_SYMBOL_DELIMITER, Boolean debug)
        {
            SGDelimiter delimiterResult = default;

            var arrayList = new ArrayList(array_SYMBOL_DELIMITER);

            var list_DELIMITER = new List<SGSymbol>();

            var list_DELIMITER__REPRESENTATION = new List<SGSymbol>();

            MakeOneFirstVoid(whitespace, invisible, list_DELIMITER);

            MakeTwoSecondVoid(arrayList, list_DELIMITER);

            MakeThreeThirdVoid(list_DELIMITER, list_DELIMITER__REPRESENTATION);

            delimiterResult = new SGDelimiter(whitespace, invisible, text, list_DELIMITER, list_DELIMITER__REPRESENTATION, debug);

            return delimiterResult;
        }
    }
}

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static SGDelimiter MakeDelimiterNew(Boolean lone, SEExpression[] array_EXPRESSION_DELIMITER, Boolean debug)
        {
            SGDelimiter delimiterResult = default;       

            var arrayList = new ArrayList(array_EXPRESSION_DELIMITER);

            var list_DELIMITER = new List<SGSymbol>();

            var list_DELIMITER__REPRESENTATION = new List<SGSymbol>();

            MakeTwoSecondVoid(arrayList, list_DELIMITER);

            MakeThreeThirdVoid(list_DELIMITER, list_DELIMITER__REPRESENTATION);

            delimiterResult = new SGDelimiter(lone, list_DELIMITER, list_DELIMITER__REPRESENTATION, debug);

            return delimiterResult;
        }
    }
}