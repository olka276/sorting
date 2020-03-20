using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortWst
    {
		public static List<int> sort(List<int> lista)
		{
            int i;
            int j;
            int current;

            for (j = lista.Count - 2; j >= 0; j--)
            {
                current = lista[j];
                i = j + 1;
                while ((i < lista.Count) && (current > lista[i]))
                {
                    lista[i - 1] = lista[i];
                    i++;
                }
                lista[i - 1] = current;
            }

            return lista;
		}
	}
}
