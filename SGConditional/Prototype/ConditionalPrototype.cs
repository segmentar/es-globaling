using Core;

namespace Core.Shared
{
    using System;

    public partial class SGConditional
    {
        public SGConditional(Int32 value, Boolean condition, Boolean debug)
        {
            this.Value = value;

            this.Condition = condition;

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
