﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDataAccessLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> EmailAddresses { get; set; } = new List<Email> { };

    }
}
