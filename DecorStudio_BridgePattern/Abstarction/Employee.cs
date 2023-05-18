using DecorStudio_BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_BridgePattern.Abstarction
{
    //Abstarction
    public abstract class Employee
    {
        protected IEmployeeData employeeData;
        public Employee(IEmployeeData employeeData)
        {
            this.employeeData = employeeData;
        }

        public abstract void SaveEmployeeData(string name, string surname, string address, string phone, string department);
        public abstract void DeleteEmployeeData(string name, string surname);
        public abstract string GetEmployeeData();
    }
}
