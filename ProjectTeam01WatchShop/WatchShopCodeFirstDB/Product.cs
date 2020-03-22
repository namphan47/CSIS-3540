namespace WatchShopCodeFirstDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductBrand { get; set; }

        [StringLength(50)]
        public string ProductDescription { get; set; }

        public int? ProductQuantity { get; set; }

        public int? ProductPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
