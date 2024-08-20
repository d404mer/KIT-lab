using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;

namespace WpfApp1.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand MembersViewCommand { get; set; }

        private object _currentView;

        public HomeViewModel HomeVM { get; set; }
        public MembersViewModel MembersVM { get; set; }

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                onPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            MembersVM = new MembersViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            MembersViewCommand = new RelayCommand(o =>
            {
                CurrentView = MembersVM;
            });
        }
    }
}
