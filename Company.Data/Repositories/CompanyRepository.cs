using Company.Data.Infrastructure;
using Company.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company.Data.Repositories
{
    public class CompanyRepository : RepositoryBase<CompanyK>, ICompanyRepository
    {
        public CompanyRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface ICompanyRepository : IRepository<CompanyK> { }
}