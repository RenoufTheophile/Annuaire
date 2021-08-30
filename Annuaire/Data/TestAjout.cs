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
                    last = "Test",
                    first = "Test",
                    phone = "06.20.45.89.75",
                    service = "Compta",
                    date = DateTime.Parse("2020-1-1")
                },
            #endregion

                new Personne
                {
                    last = "Test2 ",
                    first = "Test2",
                    phone = "06.25.89.45.12",
                    service = "Direction",
                    date = DateTime.Parse("2020-1-2")
                },

                new Personne
                {
                    last = "Test3",
                    first = "Test3",
                    phone = "06.47.85.35.69",
                    service = "Info",
                    date = DateTime.Parse("2020-1-3")
                },

                new Personne
                {
                    last = "Test4",
                    first = "Test4",
                    phone = "06.32.59.84.15",
                    service = "Info",
                    date = DateTime.Parse("202-1-4")
                }
            );
            context.SaveChanges();
        }
    }
}