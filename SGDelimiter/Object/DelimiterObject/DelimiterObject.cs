using Core;

namespace Core.Shared
{
    using System;

    public partial class SGDelimiter
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SGDelimiter) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compressed",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Whitespace) + ':' + ' ' +  Whitespace,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Invisible) + ':' + ' ' + Invisible,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Lone) + ':' + ' ' + Lone,
                String.Empty + '.' + "compressed-raw",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Text) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(DelimiterList) + ':' + ' ' + ". . ." + ' ' + $"[{DelimiterList.Count}]",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(DelimiterRepresentationList) + ':' + ' ' + ". . ." + ' ' + $"[{DelimiterRepresentationList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Text) + ':',
                String.Empty + Text,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(DelimiterList) + ':',
                String.Empty + String.Join('\n'.ToString(), DelimiterList),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(DelimiterRepresentationList) + ':',
                String.Empty + String.Join('\n'.ToString(), DelimiterRepresentationList)
            });
        }
    }
}
