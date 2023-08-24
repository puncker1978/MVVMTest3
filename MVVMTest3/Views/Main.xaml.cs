using MVVMTest3.Models;
using MVVMTest3.ViewModel;
using System.Windows;
using System.Windows.Controls;


namespace Record_Book_MVVM.Views
{
    public partial class Main : Window
	{
		public Main()
		{
			InitializeComponent();
			MainViewModel mainViewModel = new MainViewModel();
			this.DataContext = mainViewModel;
		}

		private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

			UserList.Items.Filter = FilterMethod;


		}

		private bool FilterMethod(object obj)
		{
			var user = (User)obj;

			return user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);


		}
	}
}
