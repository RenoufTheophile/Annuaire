using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Annuaire.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string last { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public string phone { get; set; }
        public string service { get; set; }
        public string first { get; set; }
    }
}