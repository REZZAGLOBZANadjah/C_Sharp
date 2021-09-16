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
using System.Configuration;
namespace MySqlCRUD
{

    public class Employee
    {
        public int empNo { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double salary { get; set; }
        public string dep { get; set; }

    }
}
