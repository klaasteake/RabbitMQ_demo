﻿using System;

namespace DeelnemerAPI.Models
{
    public class UpdatePerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int BSN { get; set; }
    }
}
