using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Annuaire.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Service { get; set; }

        [Display(Name = "Date d'entrer")]
        [DataType(DataType.Date)]
        public DateTime Date_entrer { get; set; }

    }
    public class Employer
    {
        public string Genre { get; set; }
        public string Nom_Fammille { get; set; }
        public string Pre { get; set; }
        public string Telephone { get; set; }
    }
    public class Societer
    {
        public string Poste { get; set; }
        public DateTime Arriver { get; set; }

    }
    public class Fusion
    {
        public Employer employer { get; set; }
        public Societer societer { get; set; }
    }
}
