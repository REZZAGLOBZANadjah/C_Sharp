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

namespace WpfAppWPFWindows_PresentatioFoundation
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

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            string name = txtBox.Text;
            labl2.Content = name;
            txtBox.Text = "Hello Nadjah";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            labl2.Visibility = Visibility.Hidden;
            labl2.Content= "Hellow Rezzag lobzaa  friha ";
            MessageBox.Show("Hellow  Rezzag Lobza Nadjah");
        }
    }
}
