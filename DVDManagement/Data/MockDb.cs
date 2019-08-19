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
                var justin = new Client { Name = "Joseph  Alemu" };

                var willie = new Client { Name = "Ayel Tolosa" };

                var leoma = new Client { Name = "Yonas  Abebe" };
                var Mike = new Client { Name = "Mike  Alemu" };

                var Yosef = new Client { Name = "Yosef Tolosa" };

                var Eric = new Client { Name = "Eric North" };
                var Kanye = new Client { Name = "Kanye  West" };

                var Jay = new Client { Name = "Jay Tolosa" };

                var James = new Client { Name = "James  Abebe" };
                context.Clients.Add(Mike);
                context.Clients.Add(Yosef);
                context.Clients.Add(Eric);
                context.Clients.Add(Jay);
                context.Clients.Add(James);
                context.Clients.Add(justin);
                context.Clients.Add(willie);
                context.Clients.Add(leoma);

                // Add Author
                var authorDeMarco = new Actor
                {
                    Name = "Leonardo DiCaprio",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "The Revenant" },
                    new Dvd { Title = "The Wolf of Wall Street" },
                      new Dvd { Title = "The Revenant" },
                    new Dvd { Title = "The Great Gatsby" },
                      new Dvd { Title = "Django Unchained" },
                    new Dvd { Title = "Inceptiont" }
                }
                };

                var authorCardone = new Actor
                {
                    Name = "Morgan Freeman",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
                var authorMorgan = new Actor
                {
                    Name = "Morgan Freeman",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
                var authorBrad = new Actor
                {
                    Name = "Brad Pitt",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
                var authorMichael = new Actor
                {
                    Name = " Michael Cainen",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
             
                var authorEdward = new Actor
                {
                    Name = "Edward Norton",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
                var authorMatt = new Actor
                {
                    Name = "Matt Damon",
                    Dvds = new List<Dvd>()
                {
                    new Dvd { Title = "London Has Fallen"},
                    new Dvd { Title = "Last Knights"},
                    new Dvd { Title = "The C Word"}
                }
                };
                context.Actors.Add(authorMichael);
                context.Actors.Add(authorEdward);
                context.Actors.Add(authorMatt);
                context.Actors.Add(authorMichael);
                context.Actors.Add(authorBrad);
                context.Actors.Add(authorDeMarco);
                context.Actors.Add(authorCardone);

                context.SaveChanges();
            }
        }
 
    }
}
