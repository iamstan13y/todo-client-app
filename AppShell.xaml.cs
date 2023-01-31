using Todo.Client.Pages;

namespace Todo.Client;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ManageToDoPage), typeof(ManageToDoPage));
    }
}
