﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AppEstudo.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required (ErrorMessage ="This field is required!")]
        public string Name { get; set; }
        [Required (ErrorMessage = "This field is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
    }
}
