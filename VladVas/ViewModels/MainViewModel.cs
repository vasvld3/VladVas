



namespace VladVas.ViewModels;

internal class MainViewModel : ViewModel
{
    #region Свойство Text 

    /// <summary>
    /// Свойство: Text  Тип: string
    ///   Фрагмент кода... 
    /// </summary>
    private string? _Text;
    public string? Text { get => _Text; set => Set(ref _Text, value); }
    #endregion


    #region Команда NameCommand Выполняет:

    /// <summary>
    /// Команда NameCommand
    ///      Выполняет:
    /// </summary>

    private ICommand? _NameCommand;
    public ICommand NameCommand => _NameCommand ??=
        new LambdaCommand(OnNameCommandExecuted, CanNameCommandExecute);

    private bool CanNameCommandExecute(object p) => true;

    private void OnNameCommandExecuted(object p)
    {
        Title = Text;
    }

    #endregion

    public MainViewModel()
    {
        Title = "MainView";
    }

}
