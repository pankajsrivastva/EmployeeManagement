using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Gateway
{
    public class EmployeeGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();   

        public bool Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return _dbContext.SaveChanges()>0;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public bool Update(Employee employee)
        {
            var data = _dbContext.Employees.FirstOrDefault(c => c.iD == employee.iD);
            if (data == null)
            {
                return false;
            }
            data.Name=employee.Name;
            data.Designation = employee.Designation;
            data.Address = employee.Address;
            return _dbContext.SaveChanges() > 0;    

        }

        public bool Delete(int id)
        {
            var employee = _dbContext.Employees.FirstOrDefault(s => s.iD == id);
            if (employee == null)
            {
                return false;
            }
            _dbContext.Employees.Remove(employee);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
