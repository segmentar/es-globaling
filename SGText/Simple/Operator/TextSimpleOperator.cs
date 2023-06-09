using Core;

namespace Core.Shared
{
    using System;

    public partial class TextSimple
    {
        public static implicit operator SGText(TextSimple textSimple)
        {
            SGText textResult = default;

            textResult = textSimple.Simple;

            return textResult;
        }
    }
}
