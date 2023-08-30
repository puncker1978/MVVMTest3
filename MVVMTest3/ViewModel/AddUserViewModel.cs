using System.Windows;
using System.Windows.Input;
using MVVMTest3.Models;
using MVVMTest3.Utilities;

namespace MVVMTest3.ViewModel
{
	public class AddUserViewModel
	{

		public ICommand AddUserCommand { get; set; }

		public string? Name { get; set; }
		public string? Email { get; set; }

		public AddUserViewModel()
		{
			AddUserCommand = new RelayCommand(AddUser, CanAddUser);
		}

		private bool CanAddUser()
		{
			return true;
		}

		private void AddUser()
		{
			UserManager.AddUser(new User() { Name = Name, Email = Email });
			addUser.Close();
        }
	}
}
