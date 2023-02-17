namespace VladVas.Controls;

public class VladWindow : Window
{
    static VladWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(VladWindow), new FrameworkPropertyMetadata(typeof(VladWindow)));
    }
}
