using Core;

namespace Core.Shared
{
    using System;

    public partial class SGText
    {
        public SGText(String value, Boolean debug)
        {
            if (value == default)
            {
                this.Value = SArchitecture.RuntimeRunning.Source.Text.Value;
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
