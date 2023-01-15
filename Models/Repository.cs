namespace HRApplication.Models
{
    public class Repository
    {
        public static List<Employee> employeesList = new List<Employee>();
        public static IEnumerable<Employee> GetEmployees()
        {
            return employeesList;
        }

        public static void AddEmployee(Employee employee)
        {
            employeesList.Add(employee);
        }
    }
}
