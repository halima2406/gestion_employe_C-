namespace GesEmpAspNet.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public required string NumeroCompte { get; set; }
        public required string Titulaire { get; set; }
        public required string Type { get; set; }
        public decimal Solde { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;
        public string Statut { get; set; } = "Actif";
        public int DepartementId { get; set; }
        public Departement? Departement { get; set; }
    }
}
