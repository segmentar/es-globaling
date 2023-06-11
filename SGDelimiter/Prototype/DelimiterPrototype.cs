using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    
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

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public SGDelimiter(Boolean whitespace, Boolean invisible, Boolean empty, SGText text, List<SGSymbol> delimiterList, List<SGSymbol> delimiterRepresentationList, Boolean debug)
        {
            this.Whitespace = whitespace;

            this.Invisible = invisible;

            this.Text = text;

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

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public SGDelimiter(Boolean lone, List<SGSymbol> delimiterList, List<SGSymbol> delimiterRepresentationList, Boolean debug)
        {
            this.Lone = lone;

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