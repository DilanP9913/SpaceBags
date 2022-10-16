using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spacebags.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Spacebags.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SpacebagsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SpacebagsContext>>()))
            {
                // Look for any movies.
                if (context.BagsClass.Any())
                {
                    return;   // DB has been seeded
                }
                context.BagsClass.AddRange(
                    new BagsClass
                    {
                        Brand="Adidas",
                        Type="Badpack",
                        Size="M",
                        Material="Cotton",
                        color="black",
                        review=4.5
                    },
                    new BagsClass
                    {
                        Brand = "Nike",
                        Type = "Handbag",
                        Size = "L",
                        Material = "Cotton",
                        color = "Grey",
                        review = 3
                    },
                    new BagsClass
                    {
                        Brand = "Reebok",
                        Type = "Duffle bag",
                        Size = "S",
                        Material = "Leather",
                        color = "Blue",
                        review = 4
                    },
                    new BagsClass
                    {
                        Brand = "Fila",
                        Type = "Handbag",
                        Size = "S",
                        Material = "Leather",
                        color = "Black",
                        review = 4.8
                    }, 
                    new BagsClass
                    {
                        Brand = "Prada",
                        Type = "Handbag",
                        Size = "S",
                        Material = "Leather",
                        color = "Black",
                        review = 4
                    }, 
                    new BagsClass
                    {
                        Brand = "Nike",
                        Type = "Bagpack",
                        Size = "S",
                        Material = "Cotton",
                        color = "Red",
                        review = 4
                    },
                    new BagsClass
                    {
                        Brand = "Skybags",
                        Type = "Lugage bag",
                        Size = "L",
                        Material = "Leather",
                        color = "Black",
                        review = 3
                    }, 
                    new BagsClass
                    {
                        Brand = "Reebok",
                        Type = "Cotton",
                        Size = "M",
                        Material = "Cotton",
                        color = "Black",
                        review = 5
                    }, new BagsClass
                    {
                        Brand = "Nike",
                        Type = "duffle bag",
                        Size = "L",
                        Material = "Cotton",
                        color = "Grey",
                        review = 4.5
                    }, 
                    new BagsClass
                    {
                        Brand = "Adda",
                        Type = "Bagpack",
                        Size = "M",
                        Material = "cotton",
                        color = "White",
                        review = 3
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
