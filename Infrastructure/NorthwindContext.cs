using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Infrastructure
{
    public class NorthwindContext:System.Data.Entity.DbContext
    {
        //define db set property whose name should match physicaltable name
        //the property name should be plural of the conceptual cls

        public System.Data.Entity.DbSet<MvcApplication.Models.Product> Products { get; set; }

    }
}