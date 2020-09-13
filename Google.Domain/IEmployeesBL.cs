using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Domain
{
    public interface IEmployeesBL
    {
        string[] GetEmployees();
        string GetEmployeeName(int empId);
        int SaveEmployeeName(string empName);
    }
}
