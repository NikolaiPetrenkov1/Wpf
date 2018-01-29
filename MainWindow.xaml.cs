using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> employers;
        public ObservableCollection<Division> divisions;

        public MainWindow()
        {
            InitializeComponent();

            employers = new ObservableCollection<Employee>
            {
                new Employee
                {
                    Name="Никита Батыров", Age=21, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Петр Иванович", Age=44, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Дарья Игоревна", Age=28, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Елена Кравцева", Age=33, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Евгений Васильевич", Age=46, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Александра Петрова", Age=31, HireDate =DateTime.Now
                },
            };

            divisions = new ObservableCollection<Division>
            {
                new Division {Name = "Консультанты", Employers = { employers[0], employers[2] } },
                new Division {Name = "Менеджеры", Employers = { employers[1], employers[3] }},
                new Division {Name = "Программисты", Employers = { employers[4], employers[5] }},
            };

            divisionList.ItemsSource = divisions;

        }

        private void DivisionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeeData.ItemsSource = divisions[divisionList.SelectedIndex].Employers;
        }
    }
}
