using System;
using System.Linq;
using Bangazon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

/*  * CLASS: DbInitializer
    * PURPOSE: Checks the DB upon execution of program, and seeds if no customer exists.
    * AUTHOR: Team One to What
    * METHODS:
        Initialize(): Checks to see if DB exists, if not seeds tables with Data.
*/

namespace BangazonCLI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BangazonCLIContext(serviceProvider.GetRequiredService<DbContextOptions<BangazonCLIContext>>()))
            {
                if(context.Customer.Any())
                {
                    return;
                }

                var customers = new Customer[]
                {
                    new Customer (
                        "Dylan",
                        "Handle",
                        "Castle St",
                        "Antioch",
                        "TN",
                        37013,
                        "9879879877"
                    ),
                    new Customer (
                       "Kathy",
                        "Handle",
                        "Freedom St",
                        "Murfreesboro",
                        "TN",
                        37013,
                        "9879879877"
                    ),
                    new Customer (
                        "Pete",
                        "Handle",
                        "Fire St",
                        "Smyrna",
                        "TN",
                        37013,
                        "9879879877"
                    ),
                    new Customer (
                        "Willy",
                        "Handle",
                        "Fire St",
                        "Smyrna",
                        "TN",
                        37013,
                        "9879879877"
                    )
                };

                foreach (Customer i in customers)
                {
                    context.Customer.Add(i);
                }
                context.SaveChanges();
            }
        }
    }
}