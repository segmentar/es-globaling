using Core;

namespace Core.Shared
{
    using System;

    public partial class SGText
    {
        public static SGText Runtime_MakeTextNew(String value)
        {
            SGText textResult = default;

            textResult = MakeTextNew(value, SAPolicy.TextDebugPolicy);

            return textResult;
        }
    }
}
