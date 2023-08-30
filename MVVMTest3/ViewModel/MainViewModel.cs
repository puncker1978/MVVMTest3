using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using MVVMTest3.Models;
using MVVMTest3.Utilities;
using MVVMTest3.Views;

namespace MVVMTest3.ViewModel
{
    public class MainViewModel
	{
		public ObservableCollection<User> Users { get; set; }


		public ICommand ShowWindowCommand { get; set; }



		public MainViewModel()
		{
			Users = UserManager.GetUsers();

			ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

		}

		private bool CanShowWindow(object obj)
		{
			return true;
		}

		private void ShowWindow(object obj)
		{
			var mainWindow = obj as Window;

			AddUser addUserWin = new AddUser();
			addUserWin.Owner = mainWindow;
			addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			addUserWin.ShowDialog();
			addUserWin.Close();
		}
	}
}
