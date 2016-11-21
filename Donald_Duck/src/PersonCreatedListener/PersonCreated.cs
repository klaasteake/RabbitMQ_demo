using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonCreatedListener
{
    public class PersonCreated
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeceasedOnDate { get; set; }
        public string BSN { get; set; }

        public bool BSNIsvalid { get; set; }
    }
}
