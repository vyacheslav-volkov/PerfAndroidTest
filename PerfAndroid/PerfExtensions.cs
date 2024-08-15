using AndroidX.RecyclerView.Widget;
using MugenMvvm.Android.Members;

namespace PerfAndroid;

public static class PerfExtensions
{
    public static void SetTemplate(this RecyclerView recyclerView) => recyclerView.SetItemTemplateSelector(TemplateSelector.Instance);
}