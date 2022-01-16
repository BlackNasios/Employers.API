using System;
using System.Collections.Generic;

#nullable disable

namespace Employers.API.Models
{
    public partial class Employer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfHire { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float AnnualSalary { get; set; }
        public int Position { get; set; }

        public virtual Position PositionNavigation { get; set; }
    }
}
