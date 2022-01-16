using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Employers.API.Models;
namespace Employers.API.Data
{
    public interface ICompany
    {
        Task<IEnumerable<Employer>> GetEmployers();
    }
}
