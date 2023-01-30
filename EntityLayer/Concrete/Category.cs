using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        // erişim belirleyicisi - değişken türü - isim {get; set;}
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Kategori adını boş geçemezsiniz.")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Kategori açıklamasını boş geçemezsiniz.")]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //ilişki
        public List<Blog> Blogs { get; set; } //1----
    }
}
