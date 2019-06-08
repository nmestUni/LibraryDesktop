using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBibliothequqGestion
{
    public class User {
        public int ID { get; set; }

        public string PN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
