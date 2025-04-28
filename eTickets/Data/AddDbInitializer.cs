using eTickets.Data;
using eTickets.Models;

namespace eTickets.Data
{
    public class AddDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AddDbContext>();
                context.Database.EnsureCreated();
                {

                    //Cinemas
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                        {
                            new Cinema()
                            {
                                Name = "Cinema 1",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                                Description = "This is the description of the first cinema"
                            } ,

                            new Cinema()
                            {
                                Name = "Cinema 2",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                                Description = "This is the description of the first cinema"
                            } ,

                            new Cinema()
                            {
                                Name = "Cinema 3",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                                Description = "This is the description of the first cinema"
                            } ,

                            new Cinema()
                            {
                                Name = "Cinema 4",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                                Description = "This is the description of the first cinema"
                            } ,

                            new Cinema()
                            {
                                Name = "Cinema 5",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                                Description = "This is the description of the first cinema"
                            } ,
                        });

                        context.SaveChanges();

                    }

                    //Actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                        {
                            new Actor()
                            {
                                FullName = "Actor 1",
                                ProfilePictureURL= "http://dotnethow.net/images/actors/actor-1.jpeg",
                                Bio= "This is the Bioof the first Actor"
                            } ,

                            new Actor()
                            {
                                FullName = "Actor 2",
                                ProfilePictureURL= "http://dotnethow.net/images/actors/actor-2.jpeg",
                                Bio= "This is the Bioof the first Actor"
                            } ,

                            new Actor()
                            {
                                FullName = "Actor 3",
                                ProfilePictureURL= "http://dotnethow.net/images/actors/actor-3.jpeg",
                                Bio= "This is the Bioof the first Actor"
                            } ,

                            new Actor()
                            {
                                FullName = "Actor 4",
                                ProfilePictureURL= "http://dotnethow.net/images/actors/actor-4.jpeg",
                                Bio= "This is the Bioof the first Actor"
                            } ,

                            new Actor()
                            {
                                FullName = "Actor 5",
                                ProfilePictureURL= "http://dotnethow.net/images/actors/actor-5.jpeg",
                                Bio= "This is the Bioof the first Actor"
                            } ,
                        });
                        context.SaveChanges();
                    }

                    //Producers
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                FullName = "Producer 1",
                                ProfilePictureURL= "http://dotnethow.net/images/producers/producer-1.jpeg",
                                Bio= "This is the Bioof the first Producer"
                            } ,

                            new Producer()
                            {
                                FullName = "Producer 2",
                                ProfilePictureURL= "http://dotnethow.net/images/producers/producer-2.jpeg",
                                Bio= "This is the Bioof the first Producer"
                            } ,

                            new Producer()
                            {
                                FullName = "Producer 3",
                                ProfilePictureURL= "http://dotnethow.net/images/producers/producer-3.jpeg",
                                Bio= "This is the Bioof the first Producer"
                            } ,

                            new Producer()
                            {
                                FullName = "Producer 4",
                                ProfilePictureURL= "http://dotnethow.net/images/producers/producer-4.jpeg",
                                Bio= "This is the Bioof the first Producer"
                            } ,

                            new Producer()
                            {
                                FullName = "Producer 5",
                                ProfilePictureURL= "http://dotnethow.net/images/producers/producer-5.jpeg",
                                Bio= "This is the Bioof the first Producer"
                            } ,
                        });
                        context.SaveChanges();

                    }

                    // Movies
                    // Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        { 
                              //  new Movie()
                              //  {
                              //      Name = "Romantic Escape",
                              //      Description = "This is the Romantic Escape movie description",
                              //      Price = 19.99,
                              //      ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                              //      StartDate = DateTime.Now.AddDays(10),
                              //      EndDate = DateTime.Now.AddDays(25),
                              //      CinemaId = 1,
                              //      ProducerId = 3,
                              //      MovieCategory = MovieCategory.Romance
                              //  },
                              //
                              //new Movie()
                              //{
                              //    Name = "Drama Chronicles",
                              //    Description = "This is the Drama Chronicles movie description",
                              //    Price = 24.50,
                              //    ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                              //    StartDate = DateTime.Now.AddDays(4),
                              //    EndDate = DateTime.Now.AddDays(18),
                              //    CinemaId = 1,
                              //    ProducerId = 5,
                              //    MovieCategory = MovieCategory.Drama
                              //},
                              //
                              //new Movie()
                              //{
                              //    Name = "Horror Night",
                              //    Description = "This is the Horror Night movie description",
                              //    Price = 35.99,
                              //    ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                              //    StartDate = DateTime.Now.AddDays(-2),
                              //    EndDate = DateTime.Now.AddDays(5),
                              //    CinemaId = 1,
                              //    ProducerId = 2,
                              //    MovieCategory = MovieCategory.Horror
                              //},
                              //
                              //new Movie()
                              //{
                              //    Name = "Action Rush",
                              //    Description = "This is the Action Rush movie description",
                              //    Price = 29.99,
                              //    ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                              //    StartDate = DateTime.Now.AddDays(1),
                              //    EndDate = DateTime.Now.AddDays(10),
                              //    CinemaId = 1,
                              //    ProducerId = 2,
                              //    MovieCategory = MovieCategory.Action
                              //},

                              new Movie()
                              {
                                  Name = "Mystery Zone",
                                  Description = "This is the Mystery Zone movie description",
                                  Price = 25.99,
                                  ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                                  StartDate = DateTime.Now.AddDays(5),
                                  EndDate = DateTime.Now.AddDays(12),
                                  CinemaId = 1,
                                  ProducerId = 1,
                                  MovieCategory = MovieCategory.Comedy
                              },

                              new Movie()
                              {
                                  Name = "Sci-Fi Odyssey",
                                  Description = "This is the Sci-Fi Odyssey movie description",
                                  Price = 44.50,
                                  ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                                  StartDate = DateTime.Now.AddDays(2),
                                  EndDate = DateTime.Now.AddDays(15),
                                  CinemaId = 1,
                                  ProducerId = 4,
                                  MovieCategory = MovieCategory.Documentry
                              },

                              new Movie()
                              {
                                  Name = "Scoob",
                                  Description = "This is the Scoob movie description",
                                  Price = 39.50,
                                  ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                                  StartDate = DateTime.Now.AddDays(-10),
                                  EndDate = DateTime.Now.AddDays(-2),
                                  CinemaId = 1,
                                  ProducerId = 3,
                                  MovieCategory = MovieCategory.Cartoon
                              },

                              new Movie()
                              {
                                  Name = "Cold Soles",
                                  Description = "This is the Cold Soles movie description",
                                  Price = 39.50,
                                  ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                                  StartDate = DateTime.Now.AddDays(3),
                                  EndDate = DateTime.Now.AddDays(20),
                                  CinemaId = 1,
                                  ProducerId = 3,
                                  MovieCategory = MovieCategory.Drama
                              },
                        });
                        context.SaveChanges();
                    }


                    //Actors_Movies
                    if (context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                               new Actor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 1
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 1
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 2
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 2
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 1,
                                   MovieId = 3
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 3
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 3
                               },
                               new Actor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 4
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 4
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 4
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 2,
                                   MovieId = 5
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 5
                               },

                              new Actor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 5
                               },
                               new Actor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 5
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 3,
                                   MovieId = 6
                               },

                               new Actor_Movie()
                               {
                                   ActorId = 4,
                                   MovieId = 6
                               },

                                new Actor_Movie()
                               {
                                   ActorId = 5,
                                   MovieId = 6
                               },


                        });

                        context.SaveChanges();
                    }
                    
                        
                }
            }
        
        }

    }
}
