using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest3.Model
{
    public class Person : INotifyPropertyChanged
    {
        private readonly string str = "Поле не может быть пустым или состоять из одних пробелов";

        private Guid id;
        private string name;
        private string surname;


        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            error = str;
                        }
                        break;
                    case nameof(Surname):
                        if (string.IsNullOrWhiteSpace(Surname))
                        {
                            error = str;
                        }
                        break;
                }
                return error;
            }
        }

        public Guid Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
