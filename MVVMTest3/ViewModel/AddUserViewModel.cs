using System.Windows;
using System.Windows.Input;
using MVVMTest3.Models;
using MVVMTest3.Utilites;

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

		private bool CanAddUser(object obj)
		{
			return true;
		}

		private void AddUser(object obj)
		{
			UserManager.AddUser(new User() { Name = Name, Email = Email });
            var addUser = obj as Window;
			addUser.Close();
        }
	}
}
