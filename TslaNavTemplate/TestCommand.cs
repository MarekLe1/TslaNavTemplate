using System;
using System.Windows;
using System.Windows.Input;

namespace TslaNavTemplate
{
    public class TestCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Hello Again!");
        }
    }
}
