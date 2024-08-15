using System.Diagnostics.CodeAnalysis;
using Android.Runtime;
using MugenMvvm.Android;
using MugenMvvm.Android.Native;
using MugenMvvm.Android.Native.Constants;
using MugenMvvm.App;
using MugenMvvm.Bindings.Attributes;
using MugenMvvm.CompositeUI;
using MugenMvvm.CompositeUI.ViewModels;
using MugenMvvm.Extensions;
using PerfCore;

[assembly: BindingNamespace("PerfCore")]
[assembly: BindingNamespace("MugenMvvm.CompositeUI.ViewModels")]
[assembly: BindingNamespace("MugenMvvm.CompositeUI.Sections")]
[assembly: BindingNamespace("AndroidX.RecyclerView.Widget")]
[assembly: BindingResourceMapping("sel", "TemplateSelector", true)]

namespace PerfAndroid;

[Register("com.test.perf")]
public class MugenBootstrapper : MugenBootstrapperBase, IServiceProvider
{
    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(MugenBootstrapper))]
    public MugenBootstrapper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(MugenBootstrapper))]
    public MugenBootstrapper()
    {
    }

    protected override int Flags =>
        AndroidInitializationFlags.RecyclerViewLib |
        AndroidInitializationFlags.NoAppState;

    public object? GetService(Type serviceType) => Activator.CreateInstance(serviceType);

    protected override void Initialize()
    {
        var configuration = MugenApplicationConfiguration.Configure()
                                                         .AndroidConfigurationGeneratedBindings<MainViewModel, MainActivity>(true, null, this)
                                                         .PerfAndroidGeneratedBindingConfiguration()
                                                         .CompositeUIConfiguration(new ShellHandlerProvider())
                                                         .WithComponent(new MainSectionManager());
    }
}