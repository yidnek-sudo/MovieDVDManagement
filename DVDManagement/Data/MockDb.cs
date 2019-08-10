using DVDManagement.Data.context;
using DVDManagement.Data.model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Data
{
    public class MockDb
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<StoreDbContext>();


                // Add Customers
                var justin = new Client { Name = "Justin Noon" };

                var willie = new Client { Name = "Willie Parodi" };

                var leoma = new Client { Name = "Leoma  Gosse" };

                context.Clients.Add(justin);
                context.Clients.Add(willie);
                context.Clients.Add(leoma);

                // Add Author
                var authorDeMarco = new Author
                {
                    Name = "M J DeMarco",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "The Millionaire Fastlane" },
                    new Dvd { Title = "Unscripted" }
                }
                };

                var authorCardone = new Author
                {
                    Name = "Grant Cardone",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "The 10X Rule"},
                    new Dvd { Title = "If You're Not First, You're Last"},
                    new Dvd { Title = "Sell To Survive"}
                }
                };

                context.Authors.Add(authorDeMarco);
                context.Authors.Add(authorCardone);

                context.SaveChanges();
            }
        }
 
    }
}
