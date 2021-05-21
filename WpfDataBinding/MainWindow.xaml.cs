using System.Windows;
using WpfDataBinding.ViewModels;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person person { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MySlider.Value = 50;
            MyText.Text = MySlider.Value.ToString();

            person = new Person()
            {
                FirstName = "Nhat",
                LastName = "Vu",
                Age = 30
            };

            // DataContext is root of UI, is a dependency property
            // Binding is to bind content to class Person (View Model)
            this.DataContext = person;

            this.DataContext = new PersonViewModel();

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
