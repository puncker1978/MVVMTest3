using MVVMTest2.Model;
using MVVMTest3.View;
using System.Windows;
using System.Windows.Input;

namespace MVVMTest3.ViewModel
{
    public class ApplicationViewModel
    {
        #region Методы открытия окна для добавления нового клиента
        private static void OpenPersonWindowMethod()
        {
            PersonWindow personWindow = new();
            SetCenterPositionAndOpen(personWindow);
        }

        private static void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region Команда открытия окна для добавления нового клиента
        private RelayCommand openPersonWindowCommand;
        public RelayCommand OpenPersonWindowCommand
        {
            get
            {
                return openPersonWindowCommand ?? new RelayCommand(obj =>
                {
                    OpenPersonWindowMethod();
                }
                    );
            }
        }
        #endregion
    }
}
