﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
        public DateTime Birthday { get; set; }
        public string LocationCity { get; set; }
    }
}
