using Core;

namespace Core.Shared
{
    using System;

    public partial class DelimiterSimple
    {
        public DelimiterSimple(Boolean whitespace, Boolean invisible, params String[] delimiter)
        {
            this.Simple = SGDelimiter.Runtime_MakeDelimiterNew(whitespace, invisible, delimiter);

            return;
        }
    }
}
