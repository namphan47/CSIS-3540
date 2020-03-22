namespace WatchShopCodeFirstDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Orders = new HashSet<Order>();
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        public string EmpName { get; set; }

        [StringLength(100)]
        public string EmpAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string isActive { get; set; }

        public virtual MasterRole MasterRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
