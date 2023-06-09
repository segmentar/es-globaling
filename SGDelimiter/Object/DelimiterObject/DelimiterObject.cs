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
                String.Empty + '.' + "compressed-solid",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(DelimiterList) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(DelimiterRepresentationList) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DelimiterList) + ':',
                String.Empty, String.Join('\n'.ToString(), DelimiterList,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(DelimiterRepresentationList) + ':',
                String.Empty + String.Join('\n'.ToString(), DelimiterRepresentationList))
            });
        }
    }
}
