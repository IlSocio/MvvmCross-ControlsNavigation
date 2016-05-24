using System.Windows.Threading;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Wpf;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Core.Views;

namespace MupApps.ControlsNavigation.Sample.Wpf
{
    public class Setup
        : MvxWpfSetup
    {
        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
            _uiThreadDispatcher = dispatcher;
            _presenter = presenter;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        private readonly Dispatcher _uiThreadDispatcher;
        private readonly IMvxWpfViewPresenter _presenter;
        protected override IMvxViewDispatcher CreateViewDispatcher()
        {
            var controlPresenter = new MvxWpfControlPresenter(_presenter);
       
            return new MvxWpfViewDispatcher(_uiThreadDispatcher, controlPresenter);
        }
    }
}
