using Core;

namespace Core.Shared
{
    using System;

    public partial class SGDelimiter
    {
        public static SGDelimiter Runtime_MakeDelimiterNew(Boolean whitespace, Boolean invisible, params String[] delimiter)
        {
            SGDelimiter delimiterResult = default;

            delimiterResult = MakeDelimiterNew(whitespace, invisible, delimiter, SAPolicy.DelimiterDebugPolicy);

            return delimiterResult;
        }
    }
}
