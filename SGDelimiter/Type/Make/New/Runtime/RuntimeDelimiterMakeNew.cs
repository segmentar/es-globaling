using Core;

namespace Core.Shared
{
    using System;

    public partial class SGDelimiter
    {
        public static SGDelimiter Runtime_MakeDelimiterNew(Boolean whitespace, Boolean invisible, params String[] array_SYMBOL_DELIMITER)
        {
            SGDelimiter delimiterResult = default;

            delimiterResult = MakeDelimiterNew(whitespace, invisible, array_SYMBOL_DELIMITER, SAPolicy.DelimiterDebugPolicy);

            return delimiterResult;
        }
    }
}

namespace Core.Shared
{
    using System;

    public partial class SGDelimiter
    {
        public static SGDelimiter Runtime_MakeDelimiterNew(Boolean whitespace, Boolean invisible, Boolean empty, SGText text, params String[] array_SYMBOL_DELIMITER)
        {
            SGDelimiter delimiterResult = default;

            delimiterResult = MakeDelimiterNew(whitespace, invisible, empty, text, array_SYMBOL_DELIMITER, SAPolicy.DelimiterDebugPolicy);

            return delimiterResult;
        }
    }
}

namespace Core.Shared
{
    using System;

    public partial class SGDelimiter
    {
        public static SGDelimiter Runtime_MakeDelimiterNew(Boolean lone, params SEExpression[] array_EXPRESSION_DELIMITER)
        {
            SGDelimiter delimiterResult = default;

            delimiterResult = MakeDelimiterNew(lone, array_EXPRESSION_DELIMITER, SAPolicy.DelimiterDebugPolicy);

            return delimiterResult;
        }
    }
}
