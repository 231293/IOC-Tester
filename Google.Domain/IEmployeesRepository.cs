namespace Google.Domain
{
    public interface IEmployeesRepository
    {
        string[] GetEmployees();
        string GetEmployeeName(int empId);
        int SaveEmployeeName(string empName);
    }
}
