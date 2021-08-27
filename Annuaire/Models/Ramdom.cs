using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Annuaire.Models
{
    public class Ramdom
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
}
