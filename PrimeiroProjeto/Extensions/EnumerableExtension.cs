using System.Collections.Generic;
using System.Text;

namespace System
{
    static class EnumerableExtension
    {
        //Função para apresentação dos elementos da lista que implementa IEnumerable, 1 por linha
        public static string Print<T>(this IEnumerable<T> thisObj)
        {
            StringBuilder sb = new StringBuilder();

            foreach (T obj in thisObj)
            {
                sb.AppendLine(obj.ToString());
            }

            return sb.ToString();
        }
    }
}
