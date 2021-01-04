using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("ProductImages")]
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(200)]
        public string ImagePath { get; set; }

        [MaxLength(200)]
        public string Caption { get; set; }

        [DefaultValue(true)]
        public bool IsDefault { get; set; }

        public DateTime CreateOn { get; set; } = DateTime.Now;

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}
