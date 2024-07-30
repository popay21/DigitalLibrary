namespace DigitalLibrary
{
    public class Librarian
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Librarian(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void ManageBooks()
        {
            // ניהול ספרים
        }

        public void ManageMembers()
        {
            // ניהול קוראים
        }
    }
}
