using Employee.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Repositories
{
    public class EmployeeRepositories : IRepository<Employe>
    {

        //private readonly IDistributedCache _redisCache;
        //public async Task Deleteemployee(string Nom)
        //{
        //    await _redisCache.RemoveAsync(Nom);
        //}

        //public async Task<Employe> GetEmployee(string Nom)
        //{
        //    var emp = await _redisCache.GetStringAsync(Nom);

        //    if (String.IsNullOrEmpty(emp))
        //        return null;

        //    return JsonConvert.DeserializeObject<Employe>(emp);
        //}
        ApplicationDbContext _dbContext;

        public EmployeeRepositories(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Employe> Create(Employe _object)
        {
            var obj = await _dbContext.employees.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Employe _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Employe> GetAll()
        {
            try
            {
                return _dbContext.employees.ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Employe GetById(int Id)
        {
            return _dbContext.employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Update(Employe _object)
        {
            throw new NotImplementedException();
        }
    }
}

