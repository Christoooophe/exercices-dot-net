using System.ComponentModel.DataAnnotations;

namespace Exercices.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Prenom")]
        public string Firstname { get; set; }
    }
}
