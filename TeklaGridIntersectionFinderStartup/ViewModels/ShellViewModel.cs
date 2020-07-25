using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace TeklaGridIntersectionFinderStartup.ViewModels
{
    public class ShellViewModel : Screen
    {
        private ObservableCollection<string> _levels = new ObservableCollection<string> { "0.00"};
        public ObservableCollection<string> Levels
        {
            get { return _levels; }
            set { _levels = value; NotifyOfPropertyChange(() => Levels); }
        }

        private string _currentLevel;
        public string CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; NotifyOfPropertyChange(() => CurrentLevel); }
        }
    }
}
