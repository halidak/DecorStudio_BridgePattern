using DecorStudio_BridgePattern.Abstarction;
using DecorStudio_BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_BridgePattern.RefinedAbstraction
{
    //RefinedAbstraction for DecorationStaff
    public class DecorationStaff : Employee
    {
        public DecorationStaff(IEmployeeData employeeData) : base(employeeData)
        {
        }
        public override void SaveEmployeeData(string name, string surname, string address, string phone, string department)
        {
            employeeData.SaveEmployeeData(name, surname, address, phone, department);
        }
        public override void DeleteEmployeeData(string name, string surname)
        {
            employeeData.DeleteEmployeeData(name, surname);
        }
        public override string GetEmployeeData()
        {
            return employeeData.GetEmployeeData();
        }
    }
}
