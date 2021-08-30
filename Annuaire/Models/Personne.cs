using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Annuaire.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Telephone { get; set; }
        public string Service { get; set; }
        public string Prenom { get; set; }
    }
}