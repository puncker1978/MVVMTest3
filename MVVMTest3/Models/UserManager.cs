﻿using System.Collections.ObjectModel;

namespace MVVMTest3.Models
{
    public class UserManager
	{
		public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() { new User() { Email = "quam@aol.couk", Name = "Erich Fry" }, new User { Email = "in@yahoo.com", Name = "Virginia Salas" }, new User { Email = "luctus@google.com", Name = "Alvin Velasquez" }, new User { Email = "etiam.bibendum@hotmail.edu", Name = "Zia Hutchinson" }, new User { Email = "augue.porttitor@protonmail.org", Name = "Justin Burch" } };

		public static ObservableCollection<User> GetUsers()
		{
			return _DatabaseUsers;

		}


		public static void AddUser(User user)
		{
			_DatabaseUsers.Add(user);

		}

	}
}
