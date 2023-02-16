using Ado.Net_EmpPayRoll;

namespace Ado.Net_EmpPayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployees();
            Console.ReadLine();
        }
    }
}