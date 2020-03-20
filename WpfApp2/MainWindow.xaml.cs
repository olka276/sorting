using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
   
    public partial class MainWindow : Window
    {
        List<int> array = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

  

        private void AddToArray(List<int> array, int number)
        {
            array.Add(number);
        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (number.Text!="")
            {
                String a = number.Text;
                int num = int.Parse(a);
                all.Content += a + " ";
                AddToArray(array, num);
                number.Text = "";
            }
            else
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 10);
                AddToArray(array, random);
                all.Content += random + " ";
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wynik.Content = "";
            SortBab.sort(array);

            for(int i=0; i<array.Count; i++)
            {
                wynik.Content += array[i] + " ";
            }

           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            wynik.Content = "";
            SortWst.sort(array);

            for (int i = 0; i < array.Count; i++)
            {
                wynik.Content += array[i] + " ";
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            wynik.Content = "";
            SortWyb.sort(array);

            for (int i = 0; i < array.Count; i++)
            {
                wynik.Content += array[i] + " ";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            wynik.Content = "";
            array = SortZlicz.sort(array);

            for (int i = 0; i < array.Count; i++)
            {
                wynik.Content += array[i] + " ";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            wynik.Content = "";
            array = SortScal.sort(array);

            for (int i = 0; i < array.Count; i++)
            {
                wynik.Content += array[i] + " ";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            array.Clear();
            all.Content = "";
        }
    }
}
