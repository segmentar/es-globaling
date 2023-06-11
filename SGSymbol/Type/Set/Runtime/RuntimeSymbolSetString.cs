using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGSymbol
    {
        public static String[] Runtime_SymbolStringSet(IEnumerable<SGSymbol> enumerable)
        {
            String[] arrayResult = default;

            var list = new List<String>(SymbolStringSet(enumerable));

            var array = list.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
