using MugenMvvm.Extensions;
using MugenMvvm.iOS.Collections;
using MugenMvvm.iOS.Collections.Interfaces;
using MugenMvvm.iOS.Members;
using MugenMvvm.Metadata.Interfaces;
using PerfCore;

namespace PerfIos;

public class TestModelCellConfig : UICollectionCellTemplateConfigurationBase<UICollectionViewCell, TestModel>
{
    public static readonly TestModelCellConfig Instance = new();

    private TestModelCellConfig()
    {
    }

    protected override void Configure(UICollectionView collectionView, UICollectionViewCell cell, TestModel item, ICellTemplateSelector? templateSelector,
        IReadOnlyMetadataContext? metadata)
    {
        var view = new UILabel(new CGRect(0, 0, 200, 20));

        view.BindText().To(DataContext, m => m.DataContext.Id);
        cell.ContentView.Add(view);
    }
}