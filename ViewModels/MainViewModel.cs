using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Models;
using ContactList.Views;
using System.Collections.ObjectModel;

namespace ContactList.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string phoneNumber;
        [ObservableProperty] private string description;

        public ObservableCollection<ContactModel> Contacts { get; } = new();

        [RelayCommand]
        private async Task SaveContact()
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email))
            {
                await Shell.Current.DisplayAlert("Error", "Name and Email are required.", "OK");
                return;
            }

            var newContact = new ContactModel
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };

            Contacts.Add(newContact);

            Name = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Description = string.Empty;

            await Shell.Current.GoToAsync(nameof(ContactsPage));
        }
    }
}
