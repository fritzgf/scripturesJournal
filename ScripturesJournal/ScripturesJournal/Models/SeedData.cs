using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptureJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScripturesJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScripturesJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScripturesJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Title = "Nephi",
                        Book = "1st Nephi",
                        Chapters = "3",
                        Verses = "3",
                        Note = "I am a child of God",
                        DateAdded = DateTime.Parse("2019-6-06")
                    },

                    new Scripture
                    {
                        Title = "Repentance",
                        Book = "2nd Nephi",
                        Chapters = "4",
                        Verses = "12",
                        Note = "I am a child of God",
                        DateAdded = DateTime.Parse("2019-6-06")
                    },

                    new Scripture
                    {
                        Title = "Lehi",
                        Book = "Moroni",
                        Chapters = "2",
                        Verses = "3-4",
                        Note = "I am a child of God",
                        DateAdded = DateTime.Parse("2019-6-06")
                    },

                    new Scripture
                    {
                        Title = "Moroni",
                        Book = "Alma",
                        Chapters = "26",
                        Verses = "12",
                        Note = "I am a child of God",
                        DateAdded = DateTime.Parse("2019-6-06")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}