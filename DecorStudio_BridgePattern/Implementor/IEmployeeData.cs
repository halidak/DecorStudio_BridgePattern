using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_BridgePattern.Implementor
{
    //Implementor
    public interface IEmployeeData
    {
        void SaveEmployeeData(string name, string surname, string address, string phone, string department);
        void DeleteEmployeeData(string name, string surname);
        string GetEmployeeData();
    }
}
