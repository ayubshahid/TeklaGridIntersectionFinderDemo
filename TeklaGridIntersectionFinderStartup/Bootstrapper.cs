using Caliburn.Micro;
using System.Windows;
using TeklaGridIntersectionFinderStartup.ViewModels;

namespace TeklaGridIntersectionFinderStartup
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
