using Google.Domain;
using System;

namespace Google.Storage
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public EmployeesRepository()
        {

        }
        private static readonly string[] employees = new[]
        {
            "Employee 1", "Employee 2", "Employee 3"
        };

        public string GetEmployeeName(int empId)
        {
            throw new NotImplementedException();
        }

        public string[] GetEmployees()
        {
            // We will fetch employees from database
            return employees;
        }

        public int SaveEmployeeName(string empName)
        {
            throw new NotImplementedException();
        }
    }
}
