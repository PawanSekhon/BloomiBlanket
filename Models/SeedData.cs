using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BloomiBlanket.Data;
using System;
using System.Linq;

namespace BloomiBlanket.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BloomiBlanketContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BloomiBlanketContext>>()))
            {
                // Look for any movies.
                if (context.Blanket.Any())
                {
                    return;   // DB has been seeded
                }

                context.Blanket.AddRange(
                    new Blanket
                    {
                        Name = "BabyCharmer",
                        ManufacturingDate = DateTime.Parse("2021-2-12"),
                        Material = "Nylon",
                        Size = "King",
                        Colour= "White",
                        Price= 4.55M,
                        CustomerRating= 1
                    },

                    new Blanket
                    {
                        Name = "Royal Velvet Elegance Throw",
                        ManufacturingDate = DateTime.Parse("2020-7-10"),
                        Material = "Velvet",
                        Size = "Queen",
                        Colour = "Chocolate Brown",
                        Price = 78.4M,
                        CustomerRating = 2
                    },

                    new Blanket
                    {
                        Name = "Luxe Linen Serenity Blanket",
                        ManufacturingDate = DateTime.Parse("2022-4-08"),
                        Material = "Linen",
                        Size = "Twin",
                        Colour = "Red",
                        Price = 10.47M,
                        CustomerRating = 3
                    },


                    new Blanket
                    {
                        Name = "Regal Silk Dreamweaver",
                        ManufacturingDate = DateTime.Parse("2023-1-25"),
                        Material = "Silk",
                        Size = "King",
                        Colour = "off-white",
                        Price = 38.60M,
                        CustomerRating = 4
                    },

                    new Blanket
                    {
                        Name = "Opulent Alpaca Splendor",
                        ManufacturingDate = DateTime.Parse("2019-6-23"),
                        Material = "Nylon",
                        Size = "Queen",
                        Colour = "Grey",
                        Price = 24.1M,
                        CustomerRating = 5
                    },

                    new Blanket
                    {
                        Name = "Majestic Cashmere Comfort",
                        ManufacturingDate = DateTime.Parse("2020-9-27"),
                        Material = "Rayon",
                        Size = "Twin",
                        Colour = "Blue",
                        Price = 7.46M,
                        CustomerRating = 6
                    },

                    new Blanket
                    {
                        Name = "Aristocratic Velvet Drapery",
                        ManufacturingDate = DateTime.Parse("2019-5-17"),
                        Material = "Silk",
                        Size = "King",
                        Colour = "Green",
                        Price = 10.99M,
                        CustomerRating = 7
                    },

                    new Blanket
                    {
                        Name = "Exquisite Satin Quilt",
                        ManufacturingDate = DateTime.Parse("2021-8-22"),
                        Material = "Satin",
                        Size = "Queen",
                        Colour = "Blue",
                        Price = 15.0M,
                        CustomerRating = 8
                    },

                    new Blanket
                    {
                        Name = "Grandeur Faux Fur Masterpiece",
                        ManufacturingDate = DateTime.Parse("2022-7-09"),
                        Material = "Cotton",
                        Size = "King",
                        Colour = "Black",
                        Price = 4.55M,
                        CustomerRating = 9
                    },

                    new Blanket
                    {
                        Name = "Plush Brocade Delight",
                        ManufacturingDate = DateTime.Parse("2024-9-29"),
                        Material = "Rayon",
                        Size = "Queen",
                        Colour = "Grey",
                        Price = 9.35M,
                        CustomerRating = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
