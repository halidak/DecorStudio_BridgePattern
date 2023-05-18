using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecorStudio_BridgePattern.Abstarction;
using DecorStudio_BridgePattern.ConcreteImplementor;
using DecorStudio_BridgePattern.Implementor;
using DecorStudio_BridgePattern.RefinedAbstraction;


namespace DecorStudio_BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementator objects
            IEmployeeData businessManagerData = new BusinessManagerData();
            IEmployeeData decorationStaffData = new DecorationStaffData();

            //Abstraction objects
            Employee businessManager = new BusinessManager(businessManagerData);
            Employee decorationStaff = new DecorationStaff(decorationStaffData);

            businessManager.SaveEmployeeData("John", "Doe", "London", "123456789", "Business");
            decorationStaff.SaveEmployeeData("Jane", "Smith", "Paris", "987654321", "Decoration");

            businessManager.SaveEmployeeData("Ensar", "Hamzic", "Novi Pazar", "123456789", "Business");
            decorationStaff.SaveEmployeeData("Basila", "Medjedovic", "Novi Pazar", "987654321", "Decoration");

            Console.WriteLine(businessManager.GetEmployeeData());
            Console.WriteLine(decorationStaff.GetEmployeeData());

            businessManager.DeleteEmployeeData("Ensar", "Hamzic");
            decorationStaff.DeleteEmployeeData("Basila", "Medjedovic");

            Console.WriteLine(businessManager.GetEmployeeData());
            Console.WriteLine(decorationStaff.GetEmployeeData());


            decorationStaff.DeleteEmployeeData("Halida", "Karisik");

            Console.ReadLine();
        }
    }
}
