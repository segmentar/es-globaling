using Core;

namespace Core.Shared
{
    using System;

    using System.Linq;

    using System.Collections.Generic;

    public partial class SGDelimiter
    {
        public SGDelimiter(Boolean whitespace, Boolean invisible, List<SGSymbol> delimiterList, List<SGSymbol> delimiterRepresentationList, Boolean debug)
        {
            this.Whitespace = whitespace;

            this.Invisible = invisible;

            this.DelimiterList = delimiterList;

            this.DelimiterRepresentationList = delimiterRepresentationList;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
