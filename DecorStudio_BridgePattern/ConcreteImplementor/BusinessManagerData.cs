using DecorStudio_BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DecorStudio_BridgePattern.ConcreteImplementor
{
    //ConcreteImplementorA
    public class BusinessManagerData : IEmployeeData
    {
        public List<EmployeeInfo> employees { get; set; } = new List<EmployeeInfo>();
        public void DeleteEmployeeData(string name, string surname)
        {
            EmployeeInfo employee = employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Business Manager Data Deleted");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        public string GetEmployeeData()
        {
            string result = "Business Manager Employees:\n";
            foreach (var employee in employees)
            {
                result += $"Name: {employee.Name} {employee.Surname}, Adress: {employee.Address}, Phone: {employee.Phone}, Department: {employee.Department} (Business Manager)\n";
            }
            return result;
        }

        public void SaveEmployeeData(string name, string surname, string address, string phone, string department)
        {
            employees.Add(new EmployeeInfo(name, surname, department, address, phone));
            Console.WriteLine("Business Manager Data Saved");
        }
    }
}
