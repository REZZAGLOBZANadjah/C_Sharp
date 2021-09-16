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

namespace WpfAppWGUICheckBoxcontrol
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

       // private 
        public void cbnadjah(object sender, RoutedEventArgs e)
        {
            Label1.Content += " Nadjah";
        }

        private void cbabir(object sender, RoutedEventArgs e)
        {
            Label1.Content += " Abir";
        }

        private void cbfriha(object sender, RoutedEventArgs e)
        {
            Label1.Content += " Friha";
        }

        private void cbtedjani(object sender, RoutedEventArgs e)
        {
            Label1.Content += " Tedjani";
        }

        private void cbtahar(object sender, RoutedEventArgs e)
        {
            Label1.Content += " Tahar";
        }
        //------------------ uncheched void to remouve unchecked names from list checked names -----------------------------------------
        public void uncheched(string UncheckedName)
        {
            string names = Label1.Content.ToString();
            var myList = names.Split(' ').ToList();
            if (myList.Contains(UncheckedName))
            {
                myList.Remove(UncheckedName);
                string newList = string.Join(" ", myList);
                Label1.Content = newList;
            }
        }

        //------------------------------------------------------------
        // UNCHECKED BOX Nadjah
        private void UNcbnadjah(object sender, RoutedEventArgs e)
        {
            uncheched("Nadjah");
        }

        // UNCHECKED BOX bAbir
        private void UNcbAbir(object sender, RoutedEventArgs e)
        {
            uncheched("Abir");
            //Label1.Content = "";

        }
        // UNCHECKED BOX Friha
        private void UNcbFriha(object sender, RoutedEventArgs e)
        {
            //Label1.Content = "";
            uncheched("Friha");
        }
        // UNCHECKED BOX Tedjani
        private void UNcbTedjani(object sender, RoutedEventArgs e)
        {
            //Label1.Content = "";
            uncheched("Tedjani");


        }
        // UNCHECKED BOX Tahar
        private void UNcbTahar(object sender, RoutedEventArgs e)
        {
            uncheched("Tahar");

        }

        private void BtnClear(object sender, RoutedEventArgs e)
        {
            Label1.Content = "";
        }

        private void RBPay(object sender, RoutedEventArgs e)
        {
            Label1.Content = "Pay";

        }

        private void RBNPay(object sender, RoutedEventArgs e)
        {
            Label1.Content = "Not Pay";

        }

        private void RBFree(object sender, RoutedEventArgs e)
        {
            Label1.Content = "Free";

        }
    }
}
