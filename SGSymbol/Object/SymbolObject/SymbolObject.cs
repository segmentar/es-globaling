using Core;

namespace Core.Shared
{
    using System;

    public partial class SGSymbol
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SGSymbol) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compressed",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compressed-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Value) + ':' + ' ' + $"[{Value}]",
                String.Empty + '}'
            });
        }
    }
}
