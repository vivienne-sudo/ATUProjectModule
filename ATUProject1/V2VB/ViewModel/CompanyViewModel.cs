using System;
using V2VB.Services;
using V2VB.Model;
using Xamarin.Forms;


namespace V2VB.ViewModel
{
    public class CompanyViewModel : BaseViewModel
    {
        private readonly ICompanyService _companyService;
        private readonly INavigationService _navigationService;

        public CompanyViewModel(ICompanyService companyService, INavigationService navigationService)
        {
            _companyService = companyService;
            _navigationService = navigationService;
        }

        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _addressLine1;
        public string AddressLine1
        {
            get => _addressLine1;
            set => SetProperty(ref _addressLine1, value);
        }

        private string _addressLine2;
        public string AddressLine2
        {
            get => _addressLine2;
            set => SetProperty(ref _addressLine2, value);
        }

        private string _city;
        public string City
        {
            get => _city;
            set => SetProperty(ref _city, value);
        }

        private string _county;
        public string County
        {
            get => _county;
            set => SetProperty(ref _county, value);
        }

        private string _eircode;
        public string Eircode
        {
            get => _eircode;
            set => SetProperty(ref _eircode, value);
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetProperty(ref _phoneNumber, value);
        }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => SetProperty(ref _createdAt, value);
        }

        public ICommand SaveCommand => new Command(async () =>
        {
            var company = new Company
            {
                Id = Id,
                Name = Name,
                Email = Email,
                Password = Password,
                AddressLine1 = AddressLine1,
                AddressLine2 = AddressLine2,
                City = City,
                County = County,
                Eircode = Eircode,
                PhoneNumber = PhoneNumber,
                CreatedAt = CreatedAt
            };

            if (company.Id == 0)
            {
                await _companyService.CreateCompanyAsync(company);
            }
            else
            {
                await _companyService.UpdateCompanyAsync(company);
            }

            await _navigationService.NavigateBackAsync();
        });
    }
}

