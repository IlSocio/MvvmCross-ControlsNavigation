// Setup.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MvvmCross.Platform.Platform;
using MvvmCross.Core.ViewModels;
using Windows.UI.Xaml.Controls;
using MupApps.MvvmCross.Plugins.ControlsNavigation.WindowsStore;


namespace MupApps.ControlsNavigation.Sample.WindowsStore
{
    public class Setup : MvxStoreSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
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

        protected override IMvxStoreViewPresenter CreateViewPresenter(Frame rootFrame)
        {
            var viewPresenter = base.CreateViewPresenter(rootFrame);
            return new MvxStoreControlPresenter(viewPresenter);
        }
    }
}
