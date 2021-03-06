using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceStore.Data.Entities
{
    public class Customer : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public int Point { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Admin { get; set; }

        public List<Bill> Bills { get; set; }
        public List<Evaluation> Evaluations { get; set; }
    }
}
