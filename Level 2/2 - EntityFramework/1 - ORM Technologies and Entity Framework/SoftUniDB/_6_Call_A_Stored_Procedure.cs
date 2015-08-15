using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    class _6_Call_A_Stored_Procedure
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            var projects = db.usp_AllProjectsForGivenEmployee("Kevin", "Brown");
            foreach (var project in projects)
            {
                Console.WriteLine(project.Name + ", " + project.Description + ", " + project.StartDate);
            }
        }
    }
}
