using Core;

namespace Core.Shared
{
    using System;

    public partial class SGText
    {
        public static SGText MakeTextNew(String value, Boolean debug)
        {
            SGText textResult = default;

            var match_ONE__FIRST = (value == default) is true;

            if (match_ONE__FIRST is true)
            {
                value = SArchitecture.RuntimeRunning.Source.Text.Value;
            }
            else
                "false".ToString();

            textResult = new SGText(value, debug);

            return textResult;
        }
    }
}
