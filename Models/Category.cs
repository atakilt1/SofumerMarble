using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofumerMarble.Models
{
   public class Category
   {
        //tells db it is a primary key + identity column
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [DisplayName("Display Order")]

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order must be greater than zero")]
        public int DisplayOrder { get; set; }
    }
}
