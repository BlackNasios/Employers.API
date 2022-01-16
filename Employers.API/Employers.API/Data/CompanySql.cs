using Employers.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employers.API.Data
{
    public class CompanySql : ICompany
    {
        private CompanyDBContext CompanyDBContext { get; }
        public CompanySql(CompanyDBContext companyDBContext)
        {
            CompanyDBContext = companyDBContext;
        }

        public async Task<IEnumerable<Employer>> GetEmployers()
        {
            return await CompanyDBContext.Employers.ToListAsync();
        }
    }
}
