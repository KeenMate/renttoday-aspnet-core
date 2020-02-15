﻿using System;
using System.Collections.Generic;

namespace RentToday.Providers
{
    public partial class PaymentP201702
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Rental Rental { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
