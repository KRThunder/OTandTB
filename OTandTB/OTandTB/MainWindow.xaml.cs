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

namespace OTandTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Person> items = new List<Person>();
            items.Add(new Person() { Name = "Иванов", Soname = "Николай", Init = "Владимирович", Status = "ОК" });
            items.Add(new Person() { Name = "Евгений", Soname = "Смирнов", Init = "Иванович", Status = "Скоро истекает" });
            items.Add(new Person() { Name = "Сергей", Soname = "Петров", Init = "Михайлович", Status = "Имеются просроченные" });
            lvPersons.ItemsSource = items;

        }

    }

    public class Person
    {
        public string Name { get; set; }

        public string Soname { get; set; }

        public string Init { get; set; }

        public string Status { get; set; }
    }

}
