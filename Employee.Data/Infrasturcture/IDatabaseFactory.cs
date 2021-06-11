using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Infrasturcture
{
    public interface IDatabaseFactory : IDisposable
    {
        ApplicationDbContext DataContext { get; }
    }
}
