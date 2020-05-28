using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MgmtGUI.ViewModels {
    public class MainViewModel : BindableBase {
        private string _currentStatus;

        public MainViewModel() {
            CurrentStatus = "n/a";
        }

        public string CurrentStatus {
            get { return _currentStatus; }
            set { SetProperty(ref _currentStatus, value); }
        }
    }
}
