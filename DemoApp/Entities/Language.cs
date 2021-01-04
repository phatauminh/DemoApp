using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Languages")]
    public class Language
    {
        [Key]
        [MaxLength(5)]
        public string LanguageId { get; set; }

        [Required]
        [MaxLength(20)]
        public string LanguageName { get; set; }

        public bool IsDefault { get; set; }

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; }

        public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
