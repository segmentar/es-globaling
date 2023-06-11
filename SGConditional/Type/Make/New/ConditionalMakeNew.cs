using Core;

namespace Core.Shared
{
    using System;

    public partial class SGConditional
    {
        public static SGConditional MakeConditionalNew(Int32 value, Boolean debug)
        {
            SGConditional conditionalResult = default;

            Boolean condition;

            var safe_match_ONE__FIRST = (value == SAConstant.ConditionalUnsuccess) is true;

            if (safe_match_ONE__FIRST)
            {
                condition = false;
            }
            else
            {
                condition = true;
            }
           
            conditionalResult = new SGConditional(value, condition, debug);

            return conditionalResult;
        }
    }
}
