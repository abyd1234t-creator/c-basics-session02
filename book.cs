using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
   class Book ()
   {
        public string title { get; set; }
        public int pages { get; set; }

       public override string ToString()
       {
            return $"Title: {title}, Pages: {pages}";
       }
        public override bool Equals(object? obj)
        {
            if (obj is not Book)
                return false;
            Book mybook = obj as Book;
            return mybook.title == title && pages == pages;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(title, pages);
        }
    }
}
