using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio_BridgePattern
{
    // Helper class to store employee information
    public class EmployeeInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public EmployeeInfo(string name, string surname, string departemnt, string address, string phone)
        {
            Name = name;
            Surname = surname;
            Department = departemnt;
            Address = address;
            Phone = phone;
        }
    }
}
