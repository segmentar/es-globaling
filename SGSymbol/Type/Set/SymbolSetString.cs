using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGSymbol
    {
        public static IList<String> SymbolStringSet(IEnumerable<SGSymbol> enumerable)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (SGSymbol symbol in enumerable)
            {
                collectionResult.Add(symbol.Value);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
