// MvxAndroidControlPresenter.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 


using Java.Lang;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Views;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation.Droid
{
    public class MvxAndroidControlPresenter
        : MvxControlPresenter, IMvxAndroidViewPresenter
    {
        public MvxAndroidControlPresenter(IMvxViewPresenter viewPresenter) : base(viewPresenter)
        {
        }
    }
}
