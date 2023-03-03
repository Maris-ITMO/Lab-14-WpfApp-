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

namespace Lab_14_WpfApp_СамРабота_Шаблоны_данных
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                ProductName = "Томаты",
                ProductPrice = 90,
                ProductImage = "Data\\Томаты.png",
                ProductCategory = ProductCategories.Food
            }); 

            products.Add(new Product()
            {
                ProductName = "Огурцы среднеплодные",
                ProductPrice = 90,
                ProductImage = "Data\\Огурцы среднеплодные.png",
                ProductCategory = ProductCategories.Food
            }); 

            products.Add(new Product()
            {
                ProductName = "Сода пищевая 500г",
                ProductPrice = 35,
                ProductImage = "Data\\Сода пищевая.png",
                ProductCategory = ProductCategories.Food
            }); 
            
            products.Add(new Product()
            {
                ProductName = "Бананы вес",
                ProductPrice = 112,
                ProductImage = "Data\\Бананы вес.jpg",
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Терка",
                ProductPrice = 5000,
                ProductImage = "Data\\Терка.jpg",
                ProductCategory = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                ProductName = "Утюг",
                ProductPrice = 5000,
                ProductImage = "Data\\Утюг.jpg",
                ProductCategory = ProductCategories.Appliances
            });

            lstBox.ItemsSource = products;
        }
    }
}