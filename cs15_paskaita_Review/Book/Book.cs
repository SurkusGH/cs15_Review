using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_paskaita_Review
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set;}

        public Book(Guid id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Pages = new List<Page>();
        }
    }
}
