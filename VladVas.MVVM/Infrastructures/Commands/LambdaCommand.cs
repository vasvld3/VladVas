﻿

namespace VladVas.Infrastructures.Commands;

public class LambdaCommand : Command
{
    private readonly Action<object> _Execute;
    private readonly Func<object, bool> _CanExecute;

    public LambdaCommand(Action Execute, Func<bool>? CanExecute = null)
        : this(p => Execute(), CanExecute is null ? null : p => CanExecute())
    {

    }

    public LambdaCommand(Action<object> Execute, Func<object, bool>? CanExecute = null)
    {
        _Execute = Execute;
        _CanExecute = CanExecute!;
    }

    protected override bool CanExecute(object p) => _CanExecute?.Invoke(p) ?? true;

    protected override void Execute(object p) => _Execute(p);
}
