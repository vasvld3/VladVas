



namespace VladVas.ViewModels;

internal class MainViewModel : PropertyChangedBase 
{
    #region Свойство Title 

    /// <summary>
    /// Свойство: Title  Тип: string
    ///   Фрагмент кода... 
    /// </summary>
    private string? _Title;
    public string? Title { get => _Title; set => Set(ref _Title, value); }
    #endregion
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

}
