using MugenMvvm.Commands;
using MugenMvvm.Commands.Interfaces;
using MugenMvvm.ViewModels;

namespace PerfCore;

public class TestModel : DisposableBindableModelBase
{
    public TestModel(int id, string name)
    {
        Id = id;
        Name = name;
        Command = CompositeCommand.Create(this).ToCommand();
    }

    public ICompositeCommand Command { get; }

    public int Id { get; set; }

    public string Name { get; set; }

    public override string ToString() => $"{Id} - {Name}";
}