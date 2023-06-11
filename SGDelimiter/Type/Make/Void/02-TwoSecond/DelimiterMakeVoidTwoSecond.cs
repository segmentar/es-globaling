using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SGDelimiter
    {
        public static void MakeTwoSecondVoid(ArrayList array_list_DELIMITER, List<SGSymbol> list_DELIMITER)
        {
            foreach (var object_DELIMITER in array_list_DELIMITER)
            {
                if (object_DELIMITER is String)
                {
                    var cast = (object_DELIMITER as String);

                    var symbol = SGSymbol.Runtime_MakeSymbolNew(cast);

                    list_DELIMITER.Add(symbol);
                }
                else
                    "false".ToString();

                if (object_DELIMITER is SEExpression)
                {
                    var cast = (object_DELIMITER as SEExpression);

                    var symbol = SGSymbol.Runtime_MakeSymbolNew(cast.ExpressionObject.ToString());

                    list_DELIMITER.Add(symbol);
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}