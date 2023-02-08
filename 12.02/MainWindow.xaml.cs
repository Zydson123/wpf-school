using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadanko1201
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int NWD_oblicz(int a, int b)
        {
                while (b != 0)
                {
                    int reszta = a % b;
                    a = b;
                    b = reszta;
                }
                return a;
        }
        private int NWW_Oblicz(int a, int b)
        {
                int wynik = (a * b) / NWD_oblicz(a, b);
                return wynik;
        }
        private void NWD(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (a == 0 && b == 0){
                    Wynik.Text = "Nie można dwóch zer!";
                }
                else if (a == 0)
                {
                    Wynik.Text = b.ToString();
                }
                else if (b == 0)
                {
                    Wynik.Text = a.ToString();
                }
                else
                {
                    Wynik.Text = (NWD_oblicz(a, b)).ToString();
                }
            }
        }
    
        private void NWW(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if (a == 0 && b == 0)
                {
                    Wynik.Text = "Nie można dwóch zer!";
                }
                else if (a == 0)
                {
                    Wynik.Text = b.ToString();
                }
                else if (b == 0)
                {
                    Wynik.Text = a.ToString();
                }
                else
                {
                    String wynik = NWW_Oblicz(a, b).ToString();
                    Wynik.Text = wynik;
                }
            }
        }

        private void Nowy(object sender, RoutedEventArgs e)
        {
            number1.Text = "";
            number2.Text = "";
            Wynik.Text = "Tutaj będzie wynik";
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && int.TryParse(number2.Text, out int b))
            {
                if(a==0 && b == 0)
                {
                    Wynik.Text = "Nie można dwóch zer";
                }
                else if (a == 0)
                {
                    Wynik.Text = b.ToString();
                }
                else if (b == 0)
                {
                    Wynik.Text = a.ToString();
                }
                else
                {
                    String NWD = NWD_oblicz(a, b).ToString();
                    String NWW = NWW_Oblicz(a, b).ToString();
                    Wynik.Text = "NWD: " + NWD + " NWW" + NWW;
                }
            }
        }
        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autorem jest jakub bedliński", "Autor", MessageBoxButton.OK);
        }

        private void Instrukcja(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NWD to NWD a NWW to NWW", "Autor", MessageBoxButton.OK);
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(number1.Text, out int a) && a > 0 && int.TryParse(number2.Text, out int b))
            {
                String path = "C:\\Users\\kubab\\Documents\\wpf\\zadanko1201\\zadanko1201\\zapisane.txt";
                string txt = "NWD: " + NWD_oblicz(a,b).ToString() + " " + "NWW: " + NWW_Oblicz(a, b).ToString();
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(txt);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(txt);
                    }
                }
            }
        }

        private void Zielony(object sender, RoutedEventArgs e)
        {
            main.Background = Brushes.Green;
        }

        private void Niebieski(object sender, RoutedEventArgs e)
        {
            main.Background = Brushes.Blue;
        }

        private void Mala(object sender, RoutedEventArgs e)
        {
            main.FontSize = 14;
        }

        private void Duza(object sender, RoutedEventArgs e)
        {
            main.FontSize = 24;
        }
    }
    }
