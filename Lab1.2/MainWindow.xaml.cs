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

namespace Lab1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int list = 0;
        private PizzeriaEntities context = new PizzeriaEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).IsEnabled = false;
            if (!(sender as Button).IsEnabled)
            {
                if (list == 0)
                    list = 4;

                list--;
            }
            (sender as Button).IsEnabled = true;

            switch (list)
            {
                case 0:
                    PizzaDataGrid.ItemsSource = context.Pizzas.ToList();
                    break;
                case 1:
                    PizzaDataGrid.ItemsSource = context.Clients.ToList();
                    break;
                case 2:
                    PizzaDataGrid.ItemsSource = context.Personals.ToList();
                    break;
                case 3:
                    PizzaDataGrid.ItemsSource = context.Orders.ToList();
                    break;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).IsEnabled = false;
            if (!(sender as Button).IsEnabled)
            {
                if (list == 3)
                    list = -1;

                list++;
            }
            (sender as Button).IsEnabled = true;

            switch (list)
            {
                case 0:
                    PizzaDataGrid.ItemsSource = context.Pizzas.ToList();
                    break;
                case 1:
                    PizzaDataGrid.ItemsSource = context.Clients.ToList();
                    break;
                case 2:
                    PizzaDataGrid.ItemsSource = context.Personals.ToList();
                    break;
                case 3:
                    PizzaDataGrid.ItemsSource = context.Orders.ToList();
                    break;
            }
        }
    }
}
