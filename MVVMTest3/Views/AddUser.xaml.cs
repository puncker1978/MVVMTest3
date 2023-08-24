using System.Windows;
using MVVMTest3.ViewModel;

namespace MVVMTest3.Views
{

    public partial class AddUser : Window
	{
		public AddUser()
		{
			InitializeComponent();
			AddUserViewModel addUserViewModel = new AddUserViewModel();
			this.DataContext = addUserViewModel;

		}
	}
}
