using DemoApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { set; get; }
        public DateTime OrderDate { set; get; } = DateTime.Now;
        public Guid UserId { set; get; }

        [Required]
        [MaxLength(200)]
        public string ShipName { set; get; }
        
        [Required]
        [MaxLength(200)]
        public string ShipAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string ShipEmail { set; get; }

        [Required]
        [MaxLength(200)]
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual AppUser AppUser { get; set; }
    }
}
