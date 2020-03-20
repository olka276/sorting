using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortScal
    {
        private static List<int> merge(List<int> left, List<int> right)
        {
            List<int> merged = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    merged.Add(left[i]);
                    i++;
                }
                else
                {
                    merged.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                merged.Add(left[i]);
                i++;
            }
            while (j < right.Count)
            {
                merged.Add(right[j]);
                j++;
            }

            return merged;
        }

        public static List<int> sort(List<int> lista)
        {
            List<int> wynik = new List<int>();
            if (lista.Count>1)
            {
                int m = lista.Count / 2;
                List<int> left = new List<int>(lista.GetRange(0, m));
                List<int> right = new List<int>(lista.GetRange(m, lista.Count-m));
                left = sort(left);
                right = sort(right);
                wynik = merge(left, right);
                return wynik;
            }
            wynik.Add(lista[0]);
            return wynik;
        }
    }
}
