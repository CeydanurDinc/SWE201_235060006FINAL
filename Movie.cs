public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public bool IsWatched { get; set; }
    public int Rating { get; set; }   // 1–5

    public Movie(int id, string title, string genre)
    {
        Id = id;
        Title = title;
        Genre = genre;
        IsWatched = false;
        Rating = 0;
    }

    public void MarkAsWatched(int rating)
    {
        IsWatched = true;
        Rating = rating;
    }
}

