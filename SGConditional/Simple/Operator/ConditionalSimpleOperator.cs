using Core;

namespace Core.Shared
{
    using System;

    public partial class ConditionalSimple
    {
        public static implicit operator SGConditional(ConditionalSimple conditionalSimple)
        {
            SGConditional conditionalResult;

            conditionalResult = conditionalSimple.Simple;

            return conditionalResult;
        }
    }
}
