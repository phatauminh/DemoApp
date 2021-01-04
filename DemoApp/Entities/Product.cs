using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { set; get; }

        [Required]
        public decimal Price { set; get; }

        [Required]
        public decimal OriginalPrice { set; get; }

        [DefaultValue(0)]
        public int Stock { set; get; }

        public DateTime CreateOn { set; get; } = DateTime.Now;
         
        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
