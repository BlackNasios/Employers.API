using System;
using System.Collections.Generic;

#nullable disable

namespace Employers.API.Models
{
    public partial class Position
    {
        public Position()
        {
            Employers = new HashSet<Employer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employer> Employers { get; set; }
    }
}
