using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagerAvalo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public List<string> TmpList = new List<string>();

        #region Commands
        public ReactiveCommand CmdAddNoteToTable { get; }
        #endregion

        public MainWindowViewModel()
        {
            CmdAddNoteToTable = ReactiveCommand.Create(() => { Console.WriteLine("Moin"); });
        }
    }
}
