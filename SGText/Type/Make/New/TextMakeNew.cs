using Core;

namespace Core.Shared
{
    using System;

    public partial class SGText
    {
        public static SGText MakeTextNew(String value, Boolean debug)
        {
            SGText textResult = default;

            textResult = new SGText(value, debug);

            return textResult;
        }
    }
}
