using Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
   public  interface IEmployeeServices
    {
        List<Employe> GetAllEmployee();
        List<Employe> GetAllEmployees();
       // List<Employe> GetAllEmployeecmp(int companyId);
        Employe GetEmployeeByID(int id);
        Employe GetEmployeeByUserName(string user);
       // Employe GetEmployeeByUserName(string user, int cmpId);
      //  Employe GetEmployeeByUserNameCompany();
        Employe Create(Employe Employee);
        Employe Edit(Employe Employee);
        byte[] GetProfileImage(string userId);
        Employe Delete(int EmployeeId);
        //List<Employe> SelectListItemEmployeeHierarchy(bool SupInclut = true, bool AddAll = false);
        //List<Employe> SelectListItemSoldeEmployeeHierarchy(bool SupInclut = true, bool AddAll = false);
        //List<Employe> ListSoldeEmpLByhierarchyByCMPSelected(bool SupInclut = true);
        //List<Employe> ListSoldeEmpLByhierarchyByCMPSelected(int companyId, string userName, bool SupInclut = true);
        //List<Employe> ListEmpLByhierarchy(bool SupInclut = true);
        //List<Employe> ListEmpLByhierarchyByCMPSelected(bool SupInclut = true);
        //List<Employe> ListEmpLByhierarchyWithoutCMP(bool SupInclut = true);
        //List<Employe> SelectListItemEmployeeWithoutuser();
        //List<Employe> GetAllEmployeeByCompanyId();
        //List<Employe> ListEmpLByhierarchyWithoutCompany(bool SupInclut = true);
      //  List<DestinataireViewModel> GetAllDestinatairesByCompanyId(int companyId);
     //   string CheckEmployeeExitMail(ApplicationUser user, int employeeId);
     //   string CheckUnicityEmployeeParameterCreate(List<Employe> employees, EmployeeViewModel Employee);
       // string CheckUnicityEmployeeParameterUpdate(List<Employe> employees, EmployeeViewModel Employee);
       // string CheckUnicityEmployeeMailAffectToUser(Employe Employee);
        //bool CheckUnicityEmployeeMailGenerateUser(Employe empl);
        //List<Employe> GetAllEmployeeRemplacant(bool isSysAdmin, int id);
        //List<Employe> GetAllEmployeeRemplacant(bool isSysAdmin, int id, int companyID);
        //List<Employe> GetAllEmployeeByCompanyId(int companyID);
        //List<Employe> ListSoldeEmpLByhierarchy(bool SupInclut = true);
        //bool checkEmployeeHaveWFLeave();
        //bool checkEmployeeHaveWFOM();
        //bool checkEmployeeHaveWFExpense();
    }
}
