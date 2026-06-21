using System.ComponentModel.DataAnnotations;

namespace SofumerMarble.Models
{
   public class Category
   {
        //tells db it is a primary key + identity column
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
