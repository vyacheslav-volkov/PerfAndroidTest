using MugenMvvm.iOS.Collections;
using MugenMvvm.iOS.Collections.Interfaces;

namespace PerfIos;

public class TemplateSelector : UICollectionCellConfigurationTemplateSelectorBase
{
    protected override ICellTemplateConfiguration<UICollectionView, UICollectionViewCell> SelectTemplate(object container, object? item, object? key, string? wrapperId) =>
        TestModelCellConfig.Instance;
}