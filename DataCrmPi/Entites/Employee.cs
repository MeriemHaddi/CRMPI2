using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi.Entites
{
    public class Employee:User
    {
        public int Salary { get; set; }
        public String Position { get; set; }
        public virtual ICollection<Resources> Resources { get; set; }
        public int PointOfSaleId { get; set; }
        public PointOfSale PointOfSale { get; set; }

    }
}
