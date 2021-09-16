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

namespace WpfAppGUIListViewGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { name = "Nadjah", age = 29, mail = "Rezzaglobza7@gmail.com" });
            users.Add(new User() { name = "tjani", age = 30, mail = "Rezzaglobzatj@gmail.com" });
            users.Add(new User() { name = "abir", age = 26, mail = "Rezzaglobzaab@gmail.com" });
            users.Add(new User() { name = "tahar", age = 24, mail = "Rezzaglobzata@gmail.com" });
            users.Add(new User() { name = "friha", age = 26, mail = "Rezzaglobzafr@gmail.com" });
            usersListView.ItemsSource = users;
        }
    }

    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public string mail { get; set; }
    }
}

