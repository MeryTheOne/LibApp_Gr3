﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp_Gr3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasNewsletterSubscribed { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}
