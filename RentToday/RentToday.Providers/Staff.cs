﻿using System;
using System.Collections.Generic;

namespace RentToday.Providers
{
    public partial class Staff
    {
        public Staff()
        {
            PaymentP201701 = new HashSet<PaymentP201701>();
            PaymentP201702 = new HashSet<PaymentP201702>();
            PaymentP201703 = new HashSet<PaymentP201703>();
            PaymentP201704 = new HashSet<PaymentP201704>();
            PaymentP201705 = new HashSet<PaymentP201705>();
            PaymentP201706 = new HashSet<PaymentP201706>();
            Rental = new HashSet<Rental>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public int StoreId { get; set; }
        public bool? Active { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastUpdate { get; set; }
        public byte[] Picture { get; set; }

        public virtual Address Address { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<PaymentP201701> PaymentP201701 { get; set; }
        public virtual ICollection<PaymentP201702> PaymentP201702 { get; set; }
        public virtual ICollection<PaymentP201703> PaymentP201703 { get; set; }
        public virtual ICollection<PaymentP201704> PaymentP201704 { get; set; }
        public virtual ICollection<PaymentP201705> PaymentP201705 { get; set; }
        public virtual ICollection<PaymentP201706> PaymentP201706 { get; set; }
        public virtual ICollection<Rental> Rental { get; set; }
    }
}
