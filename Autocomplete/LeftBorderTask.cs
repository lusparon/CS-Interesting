﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    // Внимание!
    // Есть одна распространенная ловушка при сравнении строк: строки можно сравнивать по-разному:
    // с учетом регистра, без учета, зависеть от кодировки и т.п.
    // В файле словаря все слова отсортированы методом StringComparison.OrdinalIgnoreCase.
    // Во всех функциях сравнения строк в C# можно передать способ сравнения.
    public class LeftBorderTask
    {
        /// <returns>
        /// Возвращает индекс левой границы. То есть индекс максимальной фразы, которая не начинается с prefix и меньшая prefix.
        /// Если такой нет, то возвращает -1
        /// </returns>
        /// <remarks>
        /// Функция должна быть рекурсивной
        /// и работать за O(log(items.Length)*L), где L — ограничение сверху на длину фразы
        /// </remarks>
        public static int GetLeftBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            // IReadOnlyList похож на List, но у него нет методов модификации списка.
            // Этот код решает задачу, но слишком неэффективно. Замените его на бинарный поиск!
            /*for (int i = 0; i < phrases.Count; i++)
            {
                if (string.Compare(prefix, phrases[i], StringComparison.OrdinalIgnoreCase) < 0
                    || phrases[i].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    return i - 1;
            }

            return phrases.Count - 1;
            */
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (string.Compare(prefix, phrases[middle], StringComparison.OrdinalIgnoreCase) < 0
                    || phrases[middle].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    right = middle;
                else left = middle + 1;
            }
            if (phrases[right] == prefix)
                return right-1;
            return -1;




            /* while (left < right)
             {
                 var middle = Math.Abs((right + left) / 2);
                 if (string.Compare(prefix, phrases[middle], StringComparison.OrdinalIgnoreCase) < 0 )
                     right = middle;
                 else left = middle +1 ;
             }
             if (phrases[right] == prefix)
                return right;
             return phrases.Count - 1;*/




        }
    }
}
