using System;


namespace Employers.API.DomainModels
{
    public class Employer
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
