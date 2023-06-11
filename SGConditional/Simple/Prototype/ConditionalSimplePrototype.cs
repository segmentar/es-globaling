using Core;

namespace Core.Shared
{
    using System;

    public partial class ConditionalSimple
    {
        public ConditionalSimple(Int32 value)
        {
            this.Simple = SGConditional.Runtime_MakeConditionalNew(value);

            return;
        }
    }
}
