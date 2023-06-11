using Core;

namespace Core.Shared
{
    using System;

    public partial class DelimiterSimple
    {
        public DelimiterSimple(Boolean whitespace, Boolean invisible, params String[] array_SYMBOL_DELIMITER)
        {
            this.Simple = SGDelimiter.Runtime_MakeDelimiterNew(whitespace, invisible, array_SYMBOL_DELIMITER);

            return;
        }
    }
}

namespace Core.Shared
{
    using System;

    public partial class DelimiterSimple
    {
        public DelimiterSimple(Boolean whitespace, Boolean invisible, SGText text, params String[] array_SYMBOL_DELIMITER)
        {
            this.Simple = SGDelimiter.Runtime_MakeDelimiterNew(whitespace, invisible, text, array_SYMBOL_DELIMITER);

            return;
        }
    }
}

namespace Core.Shared
{
    using System;

    public partial class DelimiterSimple
    {
        public DelimiterSimple(Boolean lone, params SEExpression[] array_EXPRESSION_DELIMITER)
        {
            this.Simple = SGDelimiter.Runtime_MakeDelimiterNew(lone, array_EXPRESSION_DELIMITER);

            return;
        }
    }
}
