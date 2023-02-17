namespace VladVas.ViewModels;

public class ViewModel : PropertyChangedBase
{
    #region Свойство Title 

    /// <summary>
    /// Свойство: Title  Тип: string
    ///   Содержимое заголовка окна... 
    ///      -- меняется при смене свойства Curent 
    ///             - если заданы параметры.
    ///            
    /// </summary>
    private string? _Title;
    public string? Title { get => _Title; protected set => Set(ref _Title, value); }
    #endregion

    #region Свойство Curent 

    /// <summary>
    /// Свойство: Curent  Тип: ViewModelPage
    ///   Содержимое окна. (Bindings ContentPresenter)
    ///   Доступ ограничен.
    ///     --принимает значение через метод Show()
    /// </summary>
    private ViewModelPage? _Curent;
    public ViewModelPage? Curent
    {
        get => _Curent;
        private set
        {
            if (Equals(null, value)) return;
            if (Equals(_Curent, value)) return;
            _Curent= value;
            OnPropertyChanged();

            if (value.Title is not null)
                _Title = value.Title; // Если в DataContext страницы задан заголовок.
        }
    }
    protected void Show(ViewModelPage? curent)
    {
        _Curent = curent;
    }
    #endregion

}
