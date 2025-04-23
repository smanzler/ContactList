using ContactList.Models;
using ContactList.ViewModels;

namespace ContactList.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedContact = e.CurrentSelection.FirstOrDefault() as ContactModel;
        if (selectedContact != null)
        {
            await Shell.Current.GoToAsync(nameof(ContactDetailsPage),
                new Dictionary<string, object>
                {
                    ["SelectedContact"] = selectedContact
                });
        }

        ((CollectionView)sender).SelectedItem = null;
    }

    private async void OnAddContactClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
