using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2VB.Model;

namespace V2VB.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyAsync(int id);
        Task CreateCompanyAsync(Company company);
        Task UpdateCompanyAsync(Company company);
        Task DeleteCompanyAsync(Company company);
        Task SaveCompanyAsync(Company company);
    }
}