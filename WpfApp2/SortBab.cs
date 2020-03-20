using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortBab
    {
        public static List<int> sort(List<int> numbers)
        {
            int tmp;
            List<int> wynik = new List<int>();
            wynik = numbers;
            for (int i = 0; i <wynik.Count-1; i++)
            {
                for (int j = 0; j < wynik.Count - 1; j++)
                {
                    if (wynik[j]>wynik[j+1]) {
                        tmp = wynik[j];
                        wynik[j] = wynik[j + 1];
                        wynik[j + 1] = tmp;

                    }
                }
            }

                return wynik;
        }
    }
}
