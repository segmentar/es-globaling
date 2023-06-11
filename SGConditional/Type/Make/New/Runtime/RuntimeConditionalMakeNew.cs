using Core;

namespace Core.Shared
{
    using System;

    public partial class SGConditional
    {
        public static SGConditional Runtime_MakeConditionalNew(Int32 value)
        {
            SGConditional conditionalResult = default;

            conditionalResult = MakeConditionalNew(value, SAPolicy.ConditionalDebugPolicy);

            return conditionalResult;
        }
    }
}
