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
using ListBoxStudents;
namespace ListBoxStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
      
        List<Student> students;
        List<string> nameList;
        public MainWindow()
        {

            InitializeComponent();
            string name = "Việt Nam Tùng Chiến Hà Vỹ Lộ Tính Toan Tú Linh Thịnh Nhóc Bảo Tuyền Quân Công ";
            String[] str = name.Split(' ');
            students = new List<Student>();

            for(int i=0; i< str.Length; i++)
            {
                students.Add(new Student(str[i]));
            }

            nameList = new List<string>();

            for(int i=0; i<students.Count; i++)
            {
                nameList.Add(i + "\t" + students[i].Ten);
            }

            
            lsbList.ItemsSource = nameList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
