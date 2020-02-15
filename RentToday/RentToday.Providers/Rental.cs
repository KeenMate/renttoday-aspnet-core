using System;
using System.Collections.Generic;

namespace RentToday.Providers
{
    public partial class Rental
    {
        public Rental()
        {
            PaymentP201701 = new HashSet<PaymentP201701>();
            PaymentP201702 = new HashSet<PaymentP201702>();
            PaymentP201703 = new HashSet<PaymentP201703>();
            PaymentP201704 = new HashSet<PaymentP201704>();
            PaymentP201705 = new HashSet<PaymentP201705>();
            PaymentP201706 = new HashSet<PaymentP201706>();
        }

        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public int InventoryId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int StaffId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<PaymentP201701> PaymentP201701 { get; set; }
        public virtual ICollection<PaymentP201702> PaymentP201702 { get; set; }
        public virtual ICollection<PaymentP201703> PaymentP201703 { get; set; }
        public virtual ICollection<PaymentP201704> PaymentP201704 { get; set; }
        public virtual ICollection<PaymentP201705> PaymentP201705 { get; set; }
        public virtual ICollection<PaymentP201706> PaymentP201706 { get; set; }
    }
}
