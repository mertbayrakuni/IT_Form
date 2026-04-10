namespace IT_KutuphaneOtomasyon
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Book> Books { get; set; } = [];
        override public string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }
    }
}
