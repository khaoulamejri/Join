using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        ApplicationDbContext DataContext { get; }
    }
}
