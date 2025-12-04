namespace GesEmpAspNet.Models
{
    public class Departement
    {
        public int Id { get; set; }
        public required string Nom { get; set; }
        public int NbreEmploye { get; set; } = 0;
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public string Statut { get; set; } = "Actif";
    }
}
