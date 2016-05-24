// MailView.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MupApps.ControlsNavigation.Sample.Droid.Views
{
    [Activity(Label = "")]
    public class MailView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.View_Mail);
        }
    }
}
