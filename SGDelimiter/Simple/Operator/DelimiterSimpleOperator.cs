using Core;

namespace Core.Shared
{
    using System;

    public partial class DelimiterSimple
    {
        public static implicit operator SGDelimiter(DelimiterSimple delimiterSimple)
        {
            SGDelimiter delimiterResult = default;

            delimiterResult = delimiterSimple.Simple;

            return delimiterResult;
        }
    }
}
