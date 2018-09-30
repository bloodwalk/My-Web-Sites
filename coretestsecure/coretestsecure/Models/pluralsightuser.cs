using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coretestsecure.Models
{
    public class pluralsightuser
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string NormalizedUsername { get; set; }
        public string PasswordHash { get; set; }
    }
}
