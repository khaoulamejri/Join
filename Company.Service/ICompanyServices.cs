using Company.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service
{
    public interface ICompanyServices
    { 
    List<CompanyK> GetAllCompany();
        CompanyK GetCompanyByID(int id);
    int GetCurrentCompanyID();
        CompanyK Create(CompanyK Company);
        CompanyK Edit(CompanyK Company);
        CompanyK Delete(int CompanyId);
    //List<SelectListItem> GetAllCompanyDropDownList();
        CompanyK GetCompanyByName(string name);
    List<CompanyK> GetCompaniesByUser(string UserId);
    bool CheckUnicityCompanyByName(string name);
    bool CheckUnicityCompanyByNameID(string name, int ID);
}
}
