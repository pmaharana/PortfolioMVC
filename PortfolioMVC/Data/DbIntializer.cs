using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioMVC.Models;

namespace PortfolioMVC.Data
{
    public class DbIntializer
    {   
        public static void Initialize(ApplicationDbContext db)
        {
            db.Database.EnsureCreated();

            if (db.Persons.Any())
            {
                return;
            }

            var person = new List<Person>
            {
                new Person { Name = "Pranay",
                            Description = "I am the Console of my WriteLine",
                            ImageUrl = "http://i.imgur.com/7yBhtHM.jpg"
                },
            };
            person.ForEach(p => db.Persons.Add(p));

            var projects = new List<Projects>
            {
                new Projects { Title = "Blackjack",
                    Url ="https://github.com/pmaharana/weekend",
                    Image = "https://i.ytimg.com/vi/-9YGKFdP6sY/hqdefault.jpg",
                    Description = "First weekend project"
                },

                  new Projects { Title = "Weatherman",
                    Url ="https://github.com/pmaharana/Weatherman",
                    Image = "https://i.ytimg.com/vi/-9YGKFdP6sY/hqdefault.jpg",
                    Description = "Awww yea"
                },
            };
            projects.ForEach(pr => db.Projects.Add(pr));
            db.SaveChanges();
        }

    }
}
