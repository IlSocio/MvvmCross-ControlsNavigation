// MvxTouchControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using MvvmCross.Core.Views;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.iOS
{
    public class MvxIosControlPresenter
        : MvxControlPresenter, IMvxIosViewPresenter
    {
        protected IMvxIosViewPresenter TouchViewPresenter
        {
            get
            {
                return _viewPresenter as IMvxIosViewPresenter;
            }
        }

        public MvxIosControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }

        public bool PresentModalViewController(UIViewController controller, bool animated)
        {
            return TouchViewPresenter.PresentModalViewController(controller, animated);
        }

        public void NativeModalViewControllerDisappearedOnItsOwn()
        {
            TouchViewPresenter.NativeModalViewControllerDisappearedOnItsOwn();
        }
    }
}
