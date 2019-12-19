using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace XamFormsSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _selectedTab;
        public int SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (_selectedTab == value) return;
                Debug.WriteLine($"**** {this.GetType().Name}.{nameof(SelectedTab)}:  Changing from {_selectedTab} to {value}.");

                _selectedTab = value;
                OnPropertyChanged(nameof(SelectedTab));
            }
        }

        public MainPageViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}:  ctor");
            SelectedTab = 0;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged
    }
}
