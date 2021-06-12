using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using MovieCRUD.Models;

namespace MovieCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<MovieModel> Movies { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<GenreModel> Genres { get; set; }

        public DbSet<ReviewModel> Reviews { get; set; }

        public DbSet<GenreMovieModel> GenreMovie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed MovieModel , GenreModel , GenreMovieModel
            using (var client = new HttpClient())
            {
                List<MoviesDeserialize> movies;
                List<Genre> Genres;

                var MovieListUri = new Uri(
                    "https://api.themoviedb.org/3/movie/popular?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US&page=1");
                var MovieListResponse = client.GetAsync(MovieListUri);
                MovieListResponse.Wait();
                var MovieListResuls = MovieListResponse.Result.Content.ReadAsStringAsync();
                movies = JsonSerializer.Deserialize<Root>(MovieListResuls.Result).results;
                int count = 0;

                for (int i = 0; i < movies.Count; i++)
                {
                    var movie = movies[i];
                    var MovieUri = new Uri(
                        $"https://api.themoviedb.org/3/movie/{movie.id}?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US");
                    var MovieResponse = client.GetAsync(MovieUri);
                    MovieResponse.Wait();
                    var MovieResult = MovieResponse.Result.Content.ReadAsStringAsync();
                    // Seed GenreMovie table
                    movies[i] = JsonSerializer.Deserialize<MoviesDeserialize>(MovieResult.Result);

                    for (int j = 0; j < movies[i].genres.Count; j++)
                    {
                        // Seed GenreMovie Here
                        modelBuilder.Entity<GenreMovieModel>().HasData(
                                new GenreMovieModel()
                                {
                                    Id = (count + (j + 1)), GenreId = movies[i].genres[j].id, MovieId = movies[i].id
                                })
                            ;
                    }

                    count += movies[i].genres.Count;

                    // Seed Movie 

                    var CurrentMovie = movies[i];

                    modelBuilder.Entity<MovieModel>().HasData(
                        new MovieModel()
                        {
                            backdrop_path = CurrentMovie.backdrop_path, id = CurrentMovie.id,
                            imdb_id = CurrentMovie.imdb_id,
                            overview = CurrentMovie.overview, poster_path = CurrentMovie.poster_path,
                            release_date = CurrentMovie.release_date,
                            title = CurrentMovie.title, runtime = CurrentMovie.runtime,
                            vote_average = CurrentMovie.vote_average
                        }
                    );
                }

                var GenreUri = new Uri(
                    "https://api.themoviedb.org/3/genre/movie/list?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US");
                var GenreResponse = client.GetAsync(GenreUri);
                GenreResponse.Wait();
                var GenreResult = GenreResponse.Result.Content.ReadAsStringAsync();

                Genres = JsonSerializer.Deserialize<Root>(GenreResult.Result).genres;

                foreach (var genre in Genres)
                {
                    // Seed Here
                    modelBuilder.Entity<GenreModel>().HasData(new GenreModel()
                    {
                        id = genre.id, name = genre.name
                    });
                }
            }

            // Seed Users 
            modelBuilder.Entity<UserModel>().HasData(new UserModel()
                {
                    Id = 1, UserName = "Abdullah",
                    ProfilePic = "http://farmersca.com/wp-content/uploads/2016/07/default-profile.png"
                },
                new UserModel()
                {
                    Id = 2, UserName = "Mohammed",
                    ProfilePic = "http://farmersca.com/wp-content/uploads/2016/07/default-profile.png"
                });


            // Seed Reviews 

            modelBuilder.Entity<ReviewModel>().HasData(
                // User 1
                new ReviewModel() {Id = 1, Comment = "The Best Movie", MovieId = 337404, Rating = 9.2f, UserId = 1},
                new ReviewModel() {Id = 2, Comment = "Good Movie", MovieId = 637649, Rating = 8.2f, UserId = 1},
                new ReviewModel() {Id = 3, Comment = "Not Bad", MovieId = 503736, Rating = 6.5f, UserId = 1},
                new ReviewModel() {Id = 4, Comment = "This is best movie Ever", MovieId = 578701, Rating = 9.8f, UserId = 1},
                new ReviewModel() {Id = 5, Comment = "Good Movie", MovieId = 615457, Rating = 7.3f, UserId = 1},
                new ReviewModel() {Id = 12, Comment = "Good Movie", MovieId = 573680, Rating = 7.3f, UserId = 1},
                new ReviewModel() {Id = 13, Comment = "Very Good Movie", MovieId = 259693, Rating = 7.3f, UserId = 1},
                // User 2
                new ReviewModel() {Id = 6, Comment = "very Bad", MovieId = 717192, Rating = 3.2f, UserId = 2},
                new ReviewModel() {Id = 7, Comment = "Very Good Movie", MovieId = 573680, Rating = 8.4f, UserId = 2},
                new ReviewModel() {Id = 8, Comment = "The best Movie Ever Must Watch", MovieId = 259693, Rating = 9.5f, UserId = 2},
                new ReviewModel() {Id = 9, Comment = "Not Bad", MovieId = 691179, Rating = 6.5f, UserId = 2},
                new ReviewModel() {Id = 10, Comment = "Good Movie", MovieId = 726684, Rating = 7.3f, UserId = 2},
                new ReviewModel() {Id = 11, Comment = "Very Good Movie", MovieId = 337404, Rating = 8.5f, UserId = 2},
                new ReviewModel() {Id = 14, Comment = "Good Movie", MovieId = 615457, Rating = 7.1f, UserId = 2}
                    );
        }
    }
}