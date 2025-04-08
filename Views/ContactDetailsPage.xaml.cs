namespace ContactList.Views;
public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
