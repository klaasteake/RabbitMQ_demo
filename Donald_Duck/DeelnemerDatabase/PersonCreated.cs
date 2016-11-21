using System;

namespace DeelnemerDatabase
{
    public class PersonCreated
    {
        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int BSN { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeceasedOnDate { get; set; }
    }
}
