using MugenMvvm.Bindings;
using MugenMvvm.CompositeUI.Interfaces;
using MugenMvvm.CompositeUI.Sections;
using MugenMvvm.Extensions;
using MugenMvvm.iOS.Members;
using MugenMvvm.iOS.Views;

namespace PerfIos;

public class MainView : MugenViewController
{
    protected override void OnViewDidLoad()
    {
        base.OnViewDidLoad();

        var uiCollectionView = new UICollectionView(View.Frame, new UICollectionViewFlowLayout
        {
            ItemSize = new CGSize(300, 100)
        })
        {
            AutoresizingMask = UIViewAutoresizing.All
        };

        var dataContext = Bind.DataContext<IShell>();
        uiCollectionView.SetItemTemplateSelector(new TemplateSelector());
        uiCollectionView.BindItemsSource()
                        .To(dataContext, e => ((ShellLayoutSection) e.DataContext.Layout!).Sections);
        View.Add(uiCollectionView);
    }
}