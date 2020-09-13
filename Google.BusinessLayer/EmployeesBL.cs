using Google.Domain;
using System;

namespace Google.BusinessLayer
{
    public class EmployeesBL : IEmployeesBL
    {
        IEmployeesRepository _employeesRepository;
        public EmployeesBL(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public string GetEmployeeName(int empId)
        {
            throw new NotImplementedException();
        }

        public string[] GetEmployees()
        {
            return _employeesRepository.GetEmployees();
        }

        public int SaveEmployeeName(string empName)
        {
            throw new NotImplementedException();
        }
    }
}
