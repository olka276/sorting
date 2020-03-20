using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortWyb
    {
        public static List<int> sort (List<int> lista)
        {
            List<int> wynik = new List<int>();
            wynik = lista;
            int tmp, min;
           
            for (int i=0; i<wynik.Count; i++)
            {
                min = i;
                for (int j=i+1; j<wynik.Count; j++)
                {
                    if (wynik[j] < wynik[min])
                    {
                        min = j;
                      
                    }
                    
                }
                tmp = wynik[i];
                wynik[i] = wynik[min];
                wynik[min] = tmp;
            }

            return wynik;
        }
    }
}
