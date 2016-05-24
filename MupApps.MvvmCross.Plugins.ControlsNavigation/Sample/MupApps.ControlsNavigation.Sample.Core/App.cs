// App.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 


using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace MupApps.ControlsNavigation.Sample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.FoldersViewModel>();
        }
    }
}
