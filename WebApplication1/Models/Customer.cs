﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public ObjectId Id { get; set; }

        public string surname { get; set; }

        public string lastname { get; set; }

        public string dob { get; set; }

        public string street { get; set; }

        public string postcode { get; set; }

        public string counry { get; set; }

        public string cellphone { get; set; }

        public string landlinephone { get; set; }

        public string note { get; set; }

        public string email { get; set; }
    }
}