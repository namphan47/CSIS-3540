namespace WatchShopCodeFirstDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Orders = new HashSet<Order>();
        }

        public int TransactionID { get; set; }

        public int? EmpCashierID { get; set; }

        public decimal ProductTotal { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal OverallTotal { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        public int TotalQuantity { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
