using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annuaire.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Service { get; set; }
        public DateTime Date_entre { get; set; }


    }
}
