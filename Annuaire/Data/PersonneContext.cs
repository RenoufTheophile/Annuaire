using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Annuaire.Models;

namespace Annuaire.Data
{
    public class PersonneContext :DbContext
    {
        public PersonneContext(DbContextOptions<PersonneContext> options)
           : base(options)
        {
        }

        public DbSet<Personne> Personne { get; set; }
    }
}
