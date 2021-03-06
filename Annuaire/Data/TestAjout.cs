using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Annuaire.Data;
using System;
using System.Linq;

namespace Annuaire.Models
{
    public static class TestAjout
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new PersonneContext(
                serviceProvider.GetRequiredService<DbContextOptions<PersonneContext>>());
            // Look for any Personne.
            if (context.Personne.Any())
            {
                return;   // DB has been seeded
            }

            #region snippet1
            context.Personne.AddRange(
                new Personne
                {
                    Last = "Test",
                    First = "Test",
                    Phone = "06.20.45.89.75",
                    Service = "Compta",
                    Date = DateTime.Parse("2020-1-1")
                },
            #endregion

                new Personne
                {
                    Last = "Test2 ",
                    First = "Test2",
                    Phone = "06.25.89.45.12",
                    Service = "Direction",
                    Date = DateTime.Parse("2020-1-2")
                },

                new Personne
                {
                    Last = "Test3",
                    First = "Test3",
                    Phone = "06.47.85.35.69",
                    Service = "Info",
                    Date = DateTime.Parse("2020-1-3")
                },

                new Personne
                {
                    Last = "Test4",
                    First = "Test4",
                    Phone = "06.32.59.84.15",
                    Service = "Info",
                    Date = DateTime.Parse("202-1-4")
                }
            );
            context.SaveChanges();
        }
    }
}