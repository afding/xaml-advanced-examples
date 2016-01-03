using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels
{
    public sealed class ProfileViewModel : ViewModel
    {
        private string _name;
        private int _credentialCount;
        private DateTimeOffset _hiredOn = DateTimeOffset.Now;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public int CredentialCount
        {
            get { return _credentialCount; }
            set
            {
                _credentialCount = value;
                NotifyPropertyChanged();
            }
        }

        public DateTimeOffset HiredOn
        {
            get { return _hiredOn; }
            set
            {
                _hiredOn = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand AddCredentialCommand { get; private set; }
        public ICommand SaveProfileCommand { get; private set; }
        private readonly IMessageService _messageService;

        private void AddCredential(object parameter)
        {
            this.CredentialCount++;
            _messageService.ShowDialog("New Credential Added");
        }

        private void SaveProfile(object parameter)
        {
            Profile profileToSave = new Profile();
            profileToSave.FullName = this.Name;
            profileToSave.HireDate = this.HiredOn.UtcDateTime;
            profileToSave.NumberOfCredentials = this.CredentialCount;
            // DataRepository.Save(profileToSave);
        }

        public ProfileViewModel(IMessageService messageService)
        {
            _messageService = messageService;
            AddCredentialCommand = new DelegateCommand<object>(AddCredential);
            SaveProfileCommand = new DelegateCommand<object>(SaveProfile);
        }
    }
}
