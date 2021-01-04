using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("CategoryTranslations")]
    public class CategoryTranslation
    {
        [Key]
        public int CategoryTranslationId { set; get; }
        public int CategoryId { set; get; }
        
        [Required]
        [MaxLength(200)]
        public string CategoryTranslationName { set; get; }

        [Required]
        [MaxLength(500)]
        public string SeoDescription { set; get; }

        [Required]
        [MaxLength(200)]
        public string SeoTitle { set; get; }

        [Required]
        [MaxLength(5)]
        public string LanguageId { set; get; }

        [Required]
        [MaxLength(500)]
        public string SeoAlias { set; get; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        [ForeignKey(nameof(LanguageId))]
        public Language Language { get; set; }
    }
}
