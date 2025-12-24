using System;
using System.Collections.Generic;

public class MovieTracker
{
    private List<Movie> movies = new List<Movie>();
    private List<User> users = new List<User>();
    private int nextMovieId = 1;   // AUTO ID

    public void AddMovie(string title, string genre)
    {
        Movie movie = new Movie(nextMovieId, title, genre);
        movies.Add(movie);
        nextMovieId++;
        Console.WriteLine("Movie added.");
    }

    public void RemoveMovieByTitle(string title)
    {
        Movie movie = movies.Find(
            m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase)
        );

        if (movie != null)
        {
            movies.Remove(movie);
            Console.WriteLine("Movie removed.");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }

    public void AddUser(User user)
    {
        users.Add(user);
        Console.WriteLine("User added.");
    }

    public void MarkMovieAsWatchedByTitle(string title, int rating)
    {
        Movie movie = movies.Find(
            m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase)
        );

        if (movie != null)
        {
            movie.MarkAsWatched(rating);
            Console.WriteLine("Movie marked as watched.");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }

    public void ListMovies()
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies found.");
            return;
        }

        foreach (Movie movie in movies)
        {
            Console.WriteLine(
                $"{movie.Id} - {movie.Title} | {movie.Genre} | Watched: {movie.IsWatched} | Rating: {movie.Rating}"
            );
        }
    }
}
