using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public SGSymbol(String value, Boolean debug)
        {
            this.Value = value;

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
