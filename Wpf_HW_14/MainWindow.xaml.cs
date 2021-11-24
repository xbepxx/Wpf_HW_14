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

namespace Wpf_HW_14
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
                Name = "Вентилятор",
                Price = 25,
                Image1 = "DATA/vent.jpg",
                CategoryProduct= CategoryProduct.Technic
            });
            products.Add(new Product()
            {
                Name = "Сосиска",
                Price = 5,
                Image1 = "DATA/sosiska.jpg",
                CategoryProduct = CategoryProduct.Food
            });
            LstBox.ItemsSource=products;
        }
    }
}
