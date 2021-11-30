using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.ORM.Entity
{
    public class Supplier: BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }


        public List<Product> Products { get; set; }
    }
}
