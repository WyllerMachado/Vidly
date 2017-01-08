using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DataInfra
{
    public class Context : IContext
    {
        public ApplicationDbContext CreateContext()
        {
            return new ApplicationDbContext();
        }
    }
}