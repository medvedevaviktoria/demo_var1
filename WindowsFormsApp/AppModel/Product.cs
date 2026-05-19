namespace demo_var1.AppModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Sku { get; set; }

        public int ProductNameId { get; set; }

        public int UnitOfMeasurmentId { get; set; }

        public double Price { get; set; }

        public double MaxDiscount { get; set; }

        public int ManufacturerId { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        public double RealDiscount { get; set; }

        public int Stock { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual ProductName ProductName { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual UnitOfMeasurment UnitOfMeasurment { get; set; }

        internal bool IsNew()
        {
            return IdProduct == 0;
        }
    }
}
