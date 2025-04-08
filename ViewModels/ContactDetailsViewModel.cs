using CommunityToolkit.Mvvm.ComponentModel;
using ContactList.Models;

namespace ContactList.ViewModels;

public partial class ContactDetailsViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private ContactModel contact;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("SelectedContact"))
        {
            Contact = query["SelectedContact"] as ContactModel;
        }
    }
}
