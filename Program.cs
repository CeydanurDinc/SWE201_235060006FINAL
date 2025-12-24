using System;

class Program
{
    static void Main(string[] args)
    {
        MovieTracker tracker = new MovieTracker();
        tracker.AddUser(new User(1, "Ceyda"));

        int choice;

        do
        {
            Console.WriteLine("\n--- Movie Tracking Menu ---");
            Console.WriteLine("1 - Add Movie");
            Console.WriteLine("2 - List Movies");
            Console.WriteLine("3 - Mark Movie as Watched (by Name)");
            Console.WriteLine("4 - Remove Movie (by Name)");
            Console.WriteLine("0 - Exit");
            Console.Write("Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Movie Title: ");
                    string title = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    Console.Write("Genre: ");
                    string genre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(genre))
                    {
                        Console.WriteLine("Genre cannot be empty.");
                        break;
                    }

                    tracker.AddMovie(title, genre);
                    break;

                case 2:
                    tracker.ListMovies();
                    break;

                case 3:
                    Console.Write("Movie Title: ");
                    string watchTitle = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(watchTitle))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    Console.Write("Rating (1-5): ");
                    if (!int.TryParse(Console.ReadLine(), out int rating) || rating < 1 || rating > 5)
                    {
                        Console.WriteLine("Rating must be a number between 1 and 5.");
                        break;
                    }

                    tracker.MarkMovieAsWatchedByTitle(watchTitle, rating);
                    break;

                case 4:
                    Console.Write("Movie Title to remove: ");
                    string removeTitle = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(removeTitle))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    tracker.RemoveMovieByTitle(removeTitle);
                    break;

                case 0:
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }

        } while (choice != 0);
    }
}
