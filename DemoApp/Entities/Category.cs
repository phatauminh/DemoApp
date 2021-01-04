using DemoApp.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { set; get; }
        public int? ParentId { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; }
        public ICollection<ProductInCategory> ProductInCategories { get; set; }

        public ICollection<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
