using System.Diagnostics;
using Todo.Client.DataServices;

namespace Todo.Client;

public partial class MainPage : ContentPage
{
    private readonly IRestDataService _dataService;

    public MainPage(IRestDataService dataService)
    {
        InitializeComponent();

        _dataService = dataService;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        collectionView.ItemsSource = await _dataService.GetAllToDosAsync(); 
    }

    async void OnAddToDoClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("---> Add Button Clicked.");
    }

    async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("---> Item Changed Clicked.");
    }
}