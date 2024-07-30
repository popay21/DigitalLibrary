namespace DigitalLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
        }

        public string GetDetails()
        {
            return $"{Title} by {Author}, published in {Year}";
        }

        public void SetAvailability(bool availability)
        {
            IsAvailable = availability;
        }
    }
}
