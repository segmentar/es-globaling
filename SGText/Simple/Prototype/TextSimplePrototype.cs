using Core;

namespace Core.Shared
{
    using System;

    public partial class TextSimple
    {
        public TextSimple(String value)
        {
            this.Simple = SGText.Runtime_MakeTextNew(value);

            return;
        }
    }
}
