using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL
{
    class EmployeeDL
    {
        private static List<Employee> employees = new List<Employee>();

        internal static List<Employee> Employees { get => employees; set => employees = value; }

        public static void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public static void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        public static bool EmployeeIsAvailable(string name)
        {
            foreach(Employee TempEmployee in employees)
            {
                if(TempEmployee.CurrentUser.Name==name)
                {
                    return true;
                }
            }
            return false;
        }

        public static Employee SearchnReturnEmployee(string name)
        {
            foreach (Employee TempEmployee in employees)
            {
                if (TempEmployee.CurrentUser.Name == name)
                {
                    return TempEmployee;
                }
            }
            return null;
        }
    }
}
