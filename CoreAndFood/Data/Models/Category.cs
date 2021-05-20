using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz")]
        [StringLength(25, ErrorMessage = "Karakter sayısı fazla")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
