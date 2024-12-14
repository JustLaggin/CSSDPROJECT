using CSSDPROJECT.Model;

namespace CSSDPROJECT.Manager
{
    public class EmployeeManager :EmployeeServices
    {
         
        private readonly EmployeeContext _context;
        public EmployeeManager(EmployeeContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (var employee in _context.Employees)
            {
                if (id == employee.EmployeeId)
                {
                    return employee;
                }
            }
            return null;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void UpdateEmployee(int id, Employee employee)
        {
            foreach (var e in _context.Employees)
            {
                if (id == e.EmployeeId)
                {
                    e.FirstName = employee.FirstName;
                    e.LastName = employee.LastName;
                    e.Age = employee.Age;
                    e.Address = employee.Address;
                    _context.SaveChanges();
                    return;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach (var employee in _context.Employees)
            {
                if (id == employee.EmployeeId)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
            }
        }
    }
}
