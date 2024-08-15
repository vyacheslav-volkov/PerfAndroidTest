using MugenMvvm.App.Interfaces;
using MugenMvvm.CompositeUI.Api;
using MugenMvvm.CompositeUI.Interfaces;
using MugenMvvm.Metadata.Interfaces;

namespace PerfCore;

public class MainSectionManager : IGetSectionsApiHandler<MainSectionRequest>
{
    public async IAsyncEnumerator<object>? TryInvoke(GetSectionsRequest<MainSectionRequest> request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata,
        CancellationToken cancellationToken)
    {
        for (var i = 0; i < 100; i++)
            yield return new TestModel(i, i.ToString());
    }
}