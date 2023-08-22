using MVVMTest3.View;
using System.Windows;
using System.Windows.Input;

namespace MVVMTest3.ViewModel
{
    public class ApplicationViewModel
    {
        public ICommand OpenNewClientCommand { get; private set; }

        #region Методы открытия окна для добавления нового клиента
        private void OpenNewWindowToAddNewClientMethod()
        {
            PersonWindow personWindow = new();
            SetCenterPositionAndOpen(personWindow);
        }

        private void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region Команда открытия окна для добавления нового клиента
        #endregion
    }
}
