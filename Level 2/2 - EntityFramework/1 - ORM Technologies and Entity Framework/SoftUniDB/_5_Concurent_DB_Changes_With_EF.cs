using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _5_Concurent_DB_Changes_With_EF
    {
        public static void Main()
        {
            var db1 = new SoftUniEntities();
            var db2 = new SoftUniEntities();
            db1.Employees.Find(1).FirstName = "Ivan";
            db2.Employees.Find(1).FirstName = "Gosho";
            db1.SaveChanges();
            db2.SaveChanges();
            //Gosho has overwritten the first name in Employee Table and Ivan was completely ignored.
        }
    }
}
