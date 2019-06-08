using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBibliothequqGestion
{
    public class Book {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int PagesCount { get; set; }

        //public byte[] DisplayImage { get; set; }

        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
    }
}
