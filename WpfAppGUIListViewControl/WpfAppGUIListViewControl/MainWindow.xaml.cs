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

namespace WpfAppGUIListViewControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users =new List<User>();
            users.Add(new User() { name="Nadjah",age=29});
            users.Add(new User() { name = "Abir", age = 26 });
            users.Add(new User() { name = "tjani", age = 30 });
            users.Add(new User() { name = "tahar", age = 24 });

            listView1.ItemsSource = users;//System.InvalidOperationException : 'La collection Items doit être vide pour pouvoir utiliser ItemsSource.'

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lableShow1.Content = listView1.SelectedIndex.ToString();
          lableShow1.Content = listView1.SelectedItem.ToString();

        }
    }
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
           // return base.ToString();// this show the object 
           // show the object user name and age 
            return "Name: " + this.name + " " + "Age: " + this.age;
        }

    }
}
