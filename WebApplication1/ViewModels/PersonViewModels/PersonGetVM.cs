using WebApplication1.Models;

namespace WebApplication1.ViewModels.PersonViewModels
{
    public class PersonGetVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageUrl { get; set; }
        public Profession profession { get; set; }
        public int ProfessionId { get; set; }

    }
}
