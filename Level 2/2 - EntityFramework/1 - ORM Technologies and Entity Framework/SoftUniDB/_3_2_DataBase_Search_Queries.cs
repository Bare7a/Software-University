using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _3_2_DataBase_Search_Queries
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var addresses = db.Addresses.OrderByDescending(a => a.Employees.Count).ThenBy(a => a.Town.Name).Take(10);
            foreach (var address in addresses)
            {
                Console.WriteLine("{0}, {1} - {2} employees", address.AddressText, address.Town.Name, address.Employees.Count);
            }
                
        }
    }
}
