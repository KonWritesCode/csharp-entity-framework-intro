﻿using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Author
    {
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
