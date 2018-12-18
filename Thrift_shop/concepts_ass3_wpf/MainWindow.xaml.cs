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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace CPL_assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Program p;
        public MainWindow()
        {
            p = new Program();
            InitializeComponent();
        }

        private void TabControl_Selected_1(object sender, RoutedEventArgs e)
        {
            if (showProducts_tab.IsSelected)
            {
                hide_all_grids();
                showProduct_grid.Visibility = Visibility.Visible;
            }
            else if (addProduct_tab.IsSelected)
            {
                hide_all_grids();
                addProduct_grid.Visibility = Visibility.Visible;
            }
            else if (selectProduct_tab.IsSelected)
            {
                hide_all_grids();
                selectProducts_grid.Visibility = Visibility.Visible;
            }
            else if (showBrands_tab.IsSelected)
            {
                hide_all_grids();
                showBrands_grid.Visibility = Visibility.Visible;
            }
            else if (sortProducts_tab.IsSelected)
            {
                hide_all_grids();
                sortProducts_grid.Visibility = Visibility.Visible;
            }
        }

        private void showProduct_grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            products_datagrid.ItemsSource = p.getAllProducts();
        }

        private void hide_all_grids()
        {
            showProduct_grid.Visibility = Visibility.Collapsed;
            addProduct_grid.Visibility = Visibility.Collapsed;
            selectProducts_grid.Visibility = Visibility.Collapsed;
            showBrands_grid.Visibility = Visibility.Collapsed;
            sortProducts_grid.Visibility = Visibility.Collapsed;
        }

        private void addProduct_btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (name_txt.Text == "" || price_txt.Text == "" || category_txt.Text == "" || brand_combo.SelectedIndex == -1)
            {
                this.ShowMessageAsync("Error", "Please fill all fields");
            }
            else
            {
                Product newProduct = new Product();
                newProduct.product_name = name_txt.Text;
                newProduct.price = float.Parse(price_txt.Text);
                newProduct.category = category_txt.Text;
                newProduct.brand_id = (int)brand_combo.SelectedValue;

                p.addProduct(newProduct);
                this.ShowMessageAsync("Success", "Operation done successfully");

                //Controller.addProduct(name_txt.Text, price_txt.Text, category_txt.Text, (int)brand_combo.SelectedValue);
            }
        }

        private void AddProduct_grid_Loaded(object sender, RoutedEventArgs e)
        {
            brand_combo.ItemsSource = p.getAllBrands();
        }

        private void FilterProducts_btn_Click(object sender, RoutedEventArgs e)
        {
            float price = float.Parse(selectPrice_txt.Text);
            filterProduct_grid.ItemsSource = p.getSpecificPriceProducts(price);
        }

        private void ShowBrands_grid_Loaded(object sender, RoutedEventArgs e)
        {
            brands_datagrid.ItemsSource = p.getBrandsWithNumOfProducts();
        }

        private void SortBy_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sort_by = sortBy_combo.SelectedIndex;
            if (direction_combo != null)
            {

                if (sort_by == 0)
                {
                    sortBy_datagrid.ItemsSource = p.getSortedProductsByName(direction_combo.SelectedIndex);
                }
                else
                {
                    sortBy_datagrid.ItemsSource = p.getSortedProductsByPrice(direction_combo.SelectedIndex);
                }
            }
        }

        private void Direction_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sort_by = sortBy_combo.SelectedIndex;
            if (sortBy_combo != null)
            {

                if (sort_by == 0)
                {
                    sortBy_datagrid.ItemsSource = p.getSortedProductsByName(direction_combo.SelectedIndex);
                }
                else
                {
                    sortBy_datagrid.ItemsSource = p.getSortedProductsByPrice(direction_combo.SelectedIndex);
                }
            }
        }
    }
}
