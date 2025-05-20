namespace WebApplication1.Models
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public Profession profession { get; set; }
        public int ProfessionId { get; set; }
    }
}
