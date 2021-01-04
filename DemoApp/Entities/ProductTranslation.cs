using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("ProductTranslations")]
   public  class ProductTranslation
    {
        [Key]
        public int ProductTranslationId { set; get; }
        public int ProductId { set; get; }

        [Required]
        [MaxLength(200)]
        public string ProductTranslationName { set; get; }
        public string ProductTranslationDescription { set; get; }

        [MaxLength(500)]
        public string ProductTranslationDetails { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        [Required]
        [MaxLength(200)]
        public string SeoAlias { get; set; }

        [Required]
        [MaxLength(5)]
        public string LanguageId { set; get; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [ForeignKey(nameof(LanguageId))]
        public Language Language { get; set; }
    }
}
