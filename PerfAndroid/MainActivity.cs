using _Microsoft.Android.Resource.Designer;
using AndroidX.RecyclerView.Widget;
using MugenMvvm.Android.Members;
using MugenMvvm.Android.Native.Views.Activities;

namespace PerfAndroid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : MugenActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(ResourceConstant.Layout.activity_main);
        var view = FindViewById<RecyclerView>(ResourceConstant.Id.headerRv);
        view.SetItemTemplateSelector(TemplateSelector.Instance);
    }
}