using MugenMvvm.App;
using MugenMvvm.CompositeUI;
using MugenMvvm.CompositeUI.ViewModels;
using MugenMvvm.Extensions;
using MugenMvvm.iOS;
using PerfCore;

namespace PerfIos;

[Register("AppDelegate")]
public class AppDelegate : MugenApplicationDelegate, IServiceProvider
{
    public override UIWindow? Window { get; set; }

    public object? GetService(Type serviceType) => Activator.CreateInstance(serviceType);

    protected override void Initialize(UIApplication application, NSDictionary launchOptions) =>
        MugenApplicationConfiguration.Configure()
                                     .IosConfiguration<MainViewModel, MainView>(serviceProvider: this)
                                     .CompositeUIConfiguration(new ShellHandlerProvider())
                                     .WithComponent(new MainSectionManager());
}