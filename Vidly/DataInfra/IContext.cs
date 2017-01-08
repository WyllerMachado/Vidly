using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.DataInfra
{
    public interface IContext
    {
        ApplicationDbContext CreateContext();
    }
}
