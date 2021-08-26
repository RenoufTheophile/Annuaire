using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Annuaire.Models
{
    public class PersonneParService
    {
        public List<Personne> Personnes;
        public SelectList Service;
        public string PersonneService { get; set; }
        public string SearchString { get; set; }
    }
}
