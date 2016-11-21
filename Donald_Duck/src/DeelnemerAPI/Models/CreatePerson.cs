using System;

namespace DeelnemerAPI.Models
{
    public class CreatePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int BSN { get; set; }
    }
}
