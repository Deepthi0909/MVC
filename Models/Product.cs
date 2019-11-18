using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{

    /*
     * sql server--c#
     * int-->int
     * smallint-->short
     * tinyint-->byte
       bigint-->long
     * numeric-->float/double
     * float-->float
     * money,smallmoney-->decimal
     * char,nchar,varchar-->string
     * binary-->byte, byte[]
     * bit-->bool
     * datetime-->DateTime
     */
    public class Product
    {
        //conceptual schema
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }




    }
}