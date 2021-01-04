using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Carts")]
    public class Cart
    {
        [Key]
        public int CartId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }

    }
}
