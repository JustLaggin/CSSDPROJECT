using CSSDPROJECT.Model;

namespace CSSDPROJECT.Manager
{

    public interface EmployeeServices
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(int id, Employee employee);
        void DeleteEmployee(int id);
    }
}
