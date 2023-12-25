using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SchoolDetailss
    {
        public long Id { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public DateTime StartedDate { get; set; }
        public long PhoneNumber { get; set; }
        public string Email_id { get; set; }
    }
}
