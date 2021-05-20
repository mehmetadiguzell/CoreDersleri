using System.Collections.Generic;

namespace CoreDepartman.Models
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAd { get; set; }

        //bir departman birden fazla personel içerebilir
        public IEnumerable<Personel> Personels { get; set; }
    }
}
