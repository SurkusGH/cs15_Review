using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_paskaita_Review
{
    public class Page // Internal yra private projekto lygyje
    {
        public string Content { get; set; }
        public int PageNumber { get; set; }

        public Page(string content, int pageNumber)
        {
            Content = content ?? throw new AccessViolationException(nameof(content)); // <-- pažymėjus varnelę generuojant ctor
            PageNumber = pageNumber;
        }

        public Page(string content) // <-- Overloadintas ctor
        {
            Content = content;
        }

        public Page() // <-- Tušias ctor
        {
        }

        public override string ToString()
        {
            return $"Content: {Content}, page number {PageNumber}";
        }
    }
}
