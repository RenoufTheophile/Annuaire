using Microsoft.EntityFrameworkCore;
using Annuaire.Models;

namespace Annuaire.Data
{
    public class PersonneContext : DbContext
    {
        public PersonneContext(DbContextOptions<PersonneContext> options)
            : base(options)
        {
        }

        public DbSet<Personne> Personne { get; set; }
       
    }
}