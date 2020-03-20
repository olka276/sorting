using System;

class program
{
    static int indexMinimum(List<int> lista, int start)
    {
        int min;
        int i;
        min = lista[0];
        for (i = start; i < lista.Count; i++)
        {
            if (lista[i] < min)
            {
                min = lista[i];
            }
        }

        int minIndex = lista.FindIndex(el => el == min);

        return minIndex;
    }

    static void show(List<int> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.writeline(lista[i]);
        }
    }


    static void Main()
    {
        List<int> lista = new List<int>();
        lista.Add = 5;
        lista.Add = 42;
        lista.Add = 0;
        lista.Add = 7;
        lista.Add = 1;
        lista.Add = 2;

        show(lista);
    }
}