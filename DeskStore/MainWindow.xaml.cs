using DeskStore.Models;
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

namespace DeskStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserChip.Content = UserData().Name;
            UserImage.Source = UserData().Image;
            CartItems.ItemsSource = LoadCart();
        }

        private User UserData()
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("pack://application:,,,/resources/images/user.jpg");
            bitmapImage.EndInit();
            return new User() { Email = "user@site.com", Password = "test", Name = "Femi Ayodeji", Image = bitmapImage };
        }

        private List<CartItem> LoadCart()
        {
            List<CartItem> cart = new List<CartItem>();
            cart.Add(new CartItem() { Name = "Red maxi-dress", Code = "101", Quantity = 1, Price = 50.00 });
            cart.Add(new CartItem() { Name = "Classic blue jeans", Code = "0013", Quantity = 1, Price = 35.00 });
            return cart;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            Application.Current.Windows[0].Close();
            logInWindow.ShowDialog();
        }
    }
}
