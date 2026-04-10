using System;
using System.Collections.Generic;
using System.Text;

namespace IT_KutuphaneOtomasyon
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        override public string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN})";
        }
    }
}
