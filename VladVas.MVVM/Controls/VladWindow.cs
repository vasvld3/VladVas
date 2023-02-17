namespace VladVas.Controls;

public class VladWindow : Window
{
    ViewModel? _DataContent;
    ContentPresenter? _Presenter;

    public override void OnApplyTemplate()
    {
        _Presenter = GetTemplateChild("PART_ContentPresenter") as ContentPresenter;

        base.OnApplyTemplate();
        TemplateBindings();
    }

    void TemplateBindings()
    {
        /// Согласно паттерну MVVM - DataContext
        /// не должно мбыть пустым.
        _DataContent = DataContext as ViewModel;
        if (_DataContent is null) throw new NullReferenceException("Unable to locate dataContext of type ViewModel");

        // Если содержимое не установлено пользователем,
        // то делаем привязку к Свойству: Curent, Type: ViewModel
        // (СКРЫТАЯ ПРИВЯЗКА)
        if (_Presenter!.Content is null)
            _Presenter.SetBinding(ContentPresenter.ContentProperty, "Curent");
    }
    static VladWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(VladWindow), new FrameworkPropertyMetadata(typeof(VladWindow)));
    }
}
