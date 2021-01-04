using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderId { set; get; }

        public int ProductId { set; get; }

        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
