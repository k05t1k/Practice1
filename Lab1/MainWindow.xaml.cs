using System;
using System.Collections.Generic;
using System.Globalization;
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

using Lab1.PizzeriaDataSetTableAdapters;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int list = 1;

        PizzaTableAdapter pizza = new PizzaTableAdapter();
        ClientTableAdapter clientTable = new ClientTableAdapter();
        PersonalTableAdapter personalTable = new PersonalTableAdapter();
        OrdersTableAdapter ordersTable = new OrdersTableAdapter();

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
                    PizzaDataGrid.ItemsSource = pizza.GetData();
                    break;
                case 1:
                    PizzaDataGrid.ItemsSource = clientTable.GetData();
                    break;
                case 2:
                    PizzaDataGrid.ItemsSource = personalTable.GetData();
                    break;
                case 3:
                    PizzaDataGrid.ItemsSource = ordersTable.GetData();
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
                    PizzaDataGrid.ItemsSource = pizza.GetData();
                    break;
                case 1:
                    PizzaDataGrid.ItemsSource = clientTable.GetData();
                    break;
                case 2:
                    PizzaDataGrid.ItemsSource = personalTable.GetData();
                    break;
                case 3:
                    PizzaDataGrid.ItemsSource = ordersTable.GetData();
                    break;
            }
        }
    }
}
