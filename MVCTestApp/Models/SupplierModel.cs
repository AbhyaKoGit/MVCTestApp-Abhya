﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MVCTestApp.Models
{
	public class SupplierModel
	{
        
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

    }
}

