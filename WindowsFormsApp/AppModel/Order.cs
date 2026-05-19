namespace demo_var1.AppModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderedOn { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }

        public int PosId { get; set; }

        public int ClientId { get; set; }

        public int ReceptionCode { get; set; }

        public int OrderStatusId { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual Pos Pos { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
