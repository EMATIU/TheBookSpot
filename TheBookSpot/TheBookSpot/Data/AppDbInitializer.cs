using TheBookSpot.Models;

namespace TheBookSpot.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Spare",
                            CreatedDate = DateTime.Now,
                            Price = 20.5,
                            Description = "This is the description of Spare",
                            BookCategory = Enums.BookCategory.Bestseller

                        },

                        new Book()
                        {
                            Title = "The Picture of Dorian Gray",
                            CreatedDate = DateTime.Now,
                            Price = 25.0,
                            Description = "This is the description of The Picture of Dorian Gray",
                            BookCategory = Enums.BookCategory.Classics

                        },

                        new Book()
                        {
                            Title = "Dune",
                            CreatedDate = DateTime.Now,
                            Price = 30.5,
                            Description = "This is the description of Dune",
                            BookCategory = Enums.BookCategory.SF

                        },

                        new Book()
                        {
                            Title = "The Hunger Games",
                            CreatedDate = DateTime.Now,
                            Price = 25.5,
                            Description = "This is the description of The Hunger Games",
                            BookCategory = Enums.BookCategory.Action

                        },

                        new Book()
                        {
                            Title = "Romeo and Juliet",
                            CreatedDate = DateTime.Now,
                            Price = 40.5,
                            Description = "This is the description of Romeo and Juliet",
                            BookCategory = Enums.BookCategory.Drama

                        },

                    });
                    context.SaveChanges();

                }

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Prince Harry",
                            Bio = "This is the bio of Prince Harry"
                        },

                        new Author()
                        {
                            FullName = "William Shakespeare",
                            Bio = "This is the bio of William Shakespeare"
                        },

                        new Author()
                        {
                            FullName = "Frank Herbert",
                            Bio = "This is the bio of Frank Herbert"
                        },

                        new Author()
                        {
                            FullName = "Suzanne Collins",
                            Bio = "This is the bio of Suzanne Collins"
                        },

                        new Author()
                        {
                            FullName = "Oscar Wilde",
                            Bio = "This is the bio of Oscar Wilde"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            FullName = "Polirom",
                            Bio = "This is the bio of Polirom"
                        },

                        new Publisher()
                        {
                            FullName = "Penguin",
                            Bio = "This is the bio of Penguin"
                        },

                        new Publisher()
                        {
                            FullName = "Litera",
                            Bio = "This is the bio of Litera"
                        },

                        new Publisher()
                        {
                            FullName = "Alma Classics",
                            Bio = "This is the bio of Alma Classics"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Libraries.Any())
                {
                    context.Libraries.AddRange(new List<Library>()
                    {
                        new Library()
                        {
                            LibraryName = "Libraria Universitate",
                            Description = "This is the description of Libraria Universitate"
                        }
                    });
                    context.SaveChanges();

                }

                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },

                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 5
                        },

                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 3
                        },

                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },

                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 2
                        },
                    });
                    context.SaveChanges();
                }
                
            }
        }


    }
}
