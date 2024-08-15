using MugenMvvm.App.Interfaces;
using MugenMvvm.Collections;
using MugenMvvm.CompositeUI;
using MugenMvvm.CompositeUI.Interfaces;
using MugenMvvm.CompositeUI.Sections;
using MugenMvvm.Metadata.Interfaces;

namespace PerfCore;

public class ShellHandlerProvider : ShellHandlerProviderBase
{
    protected override void
        AddRequestSections<TRequest>(TRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections) =>
        sections.Add(new ShellLayoutSection());
}