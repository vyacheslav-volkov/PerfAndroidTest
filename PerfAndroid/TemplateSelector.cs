using _Microsoft.Android.Resource.Designer;
using MugenMvvm.Android.Views.Interfaces;
using MugenMvvm.Metadata.Interfaces;

namespace PerfAndroid;

public sealed class TemplateSelector : IResourceTemplateSelector
{
    public static readonly TemplateSelector Instance = new();

    private TemplateSelector()
    {
    }

    public int TemplateTypeCount => 1;

    public int TrySelectTemplate(object container, object? item, IReadOnlyMetadataContext? metadata) => ResourceConstant.Layout.test_model_list;
}