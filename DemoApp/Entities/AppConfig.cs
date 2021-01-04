using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("AppConfigs")]
    public class AppConfig
    {
        [Key]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
