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

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MySlider.Value = 50;
            MyText.Text = MySlider.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HiButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi World!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
