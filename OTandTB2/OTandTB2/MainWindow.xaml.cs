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

namespace OTandTB2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Event> items = new List<Event>();
            items.Add(new Event() { Type = "Инструктаж", Name = "Первичная ТБ", Complete = "01/06/2013" , Finish = "01/06/2015", Price = 0, Rest= 0 });
            items.Add(new Event() { Type = "Обучение", Name = "Высоковольтные становки", Complete = "13/08/2014", Finish = "13/08/2016", Price = 20000, Rest = 13800 });
            items.Add(new Event() { Type = "Медосмотр", Name = "Психоневрология", Complete = "15/09/2015", Finish = "15/09/2016", Price = 7000, Rest = 0 });
            lvEvent.ItemsSource = items;

        }

    }

    public class Event
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Complete { get; set; }

        public string Finish { get; set; }

        public int Price { get; set; }

        public int Rest { get; set; }
    }
}
