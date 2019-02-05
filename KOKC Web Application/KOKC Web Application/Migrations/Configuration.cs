namespace KOKC_Web_Application.Migrations
{
    using KOKC_Web_Application.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KOKC_Web_Application.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KOKC_Web_Application.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
           
        context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Rating = 2,
            Price = 7.99M
        },

        new Movie
        {
            Title = "Ghostbusters ",
            ReleaseDate = DateTime.Parse("1984-3-13"),
            Genre = "Comedy",
            Rating = 5,
            Price = 8.99M
        },

        new Movie
        {
            Title = "Ghostbusters 2",
            ReleaseDate = DateTime.Parse("1986-2-23"),
            Genre = "Comedy",
            Rating = 3,
            Price = 9.99M
        },

        new Movie
        {
            Title = "Rio Bravo",
            ReleaseDate = DateTime.Parse("1959-4-15"),
            Genre = "Western",
            Rating = 4,
            Price = 3.99M
        },
        new Movie
        {
            Title = "The Predator",
            ReleaseDate = DateTime.Parse("1999-1-26"),
            Genre = "Action",
            Rating = 3,
            Price = 17.99M
        },

        new Movie
        {
            Title = "Blue Streak ",
            ReleaseDate = DateTime.Parse("1999-6-13"),
            Genre = "Comedy",
            Rating = 5,
            Price = 22.99M
        },

        new Movie
        {
            Title = "Perfect Strangers",
            ReleaseDate = DateTime.Parse("2010-9-23"),
            Genre = "Thriller",
            Rating = 4,
            Price = 19.99M
        },

        new Movie
        {
            Title = "David Crocket",
            ReleaseDate = DateTime.Parse("2015-10-15"),
            Genre = "Western",
            Rating = 3,
            Price = 23.99M
        }

        );

        }
    }
}
