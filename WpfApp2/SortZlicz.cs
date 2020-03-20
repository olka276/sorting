using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortZlicz
    {
        public static List<int> sort(List<int> lista) {

            List<int> wynik = new List<int>();
            int max = lista.Max();
            int[] box = new int[max + 1];
            for (int i=0; i<lista.Count; i++)
            {
                box[lista[i]]++;
            }
            for (int i=0; i<box.Length; i++)
            {
                for (int j=0; j<box[i]; j++)
                {
                    wynik.Add(i);
                }
            }


            return wynik;
        }
    }
}
