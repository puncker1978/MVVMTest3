using System.Windows;
using MVVMTest3.ViewModel;
using MVVMTest3.Model;
using MVVMTest3.View;

namespace MVVMTest3.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ApplicationViewModel();
        }
    }
}
