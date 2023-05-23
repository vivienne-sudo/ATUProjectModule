using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using V2VB.Services;
using V2VB.Model;
using Xamarin.Forms; 

namespace V2VB.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly IUserService _userService;
        private readonly INavigationService _navigationService;

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private bool _rememberMe;
        public bool RememberMe
        {
            get { return _rememberMe; }
            set
            {
                _rememberMe = value;
                OnPropertyChanged(nameof(RememberMe));
            }
        }

        public V2VB.Services.ICommand LoginCommand { get; }

        public LoginViewModel(IUserService userService, INavigationService navigationService)
        {
            _userService = userService;
            _navigationService = navigationService;
            LoginCommand = new V2VB.Services.Command(async () => await LoginAsync());
        } 


            private async Task LoginAsync()
        {
            var user = await _userService.AuthenticateAsync(Email, Password);

            if (user == null)
            {
                // Display error message
                return;
            }

            // Check if user is a company owner
            if (user is User)
            {
                // Save user session
                // Navigate to employee dashboard
            }
            else
            {
                // Display error message
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
