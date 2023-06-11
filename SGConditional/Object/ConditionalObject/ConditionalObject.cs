using Core;

namespace Core.Shared
{
    using System;

    public partial class SGConditional
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SGConditional) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compressed",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Condition) + ':' + ' ' + Condition,
                String.Empty + '.' + "compessed-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Value) + ':' + ' ' + Value,
                String.Empty + '}'
            });
        }
    }
}
