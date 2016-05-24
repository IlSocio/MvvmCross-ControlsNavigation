using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using MupApps.MvvmCross.Plugins.ControlsNavigation.iOS;
using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Views.Presenters;

namespace MupApps.ControlsNavigation.Sample.IPad
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            var viewPresenter = base.CreatePresenter();
            return new MvxIosControlPresenter(viewPresenter);
        }
    }
}