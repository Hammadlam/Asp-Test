using System.ComponentModel.DataAnnotations;

namespace E_Store.Models
{
    public class products
    {
        [Key]
        
        public int prod_id { get; set; }
        public string product_name { get; set; }
        public string prod_type { get; set; }
      
        public string prod_size { get; set; }
        public string prod_color { get; set; }




    }
}
