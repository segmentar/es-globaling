using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public SGSymbol(String value, Boolean debug)
        {
            if (value == default)
            {
                this.Value = null;
            }
            else
            {
                this.Value = value;
            }

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
