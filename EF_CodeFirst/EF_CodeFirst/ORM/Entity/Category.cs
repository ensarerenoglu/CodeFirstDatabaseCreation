using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.ORM.Entity
{
    public class Category : BaseEntity
    {
       
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
