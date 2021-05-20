namespace CoreDepartman.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public int DepartmanId { get; set; }
        public virtual Departman Departman { get; set; }
    }
}
