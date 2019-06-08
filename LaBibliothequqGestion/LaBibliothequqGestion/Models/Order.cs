using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBibliothequqGestion
{
    public class Order {
        public int ID { get; set; }

        public int BookID { get; set; }

        public int UserID { get; set; }

        public DateTime? TakeAwayDate { get; set; }

        public DateTime? TakeBackDate { get; set; }

        public DateTime RequestDate { get; set; }

        public int Status { get; set; }

        public virtual Book Book { get; set; }

        public virtual User User { get; set; }
    }
}
