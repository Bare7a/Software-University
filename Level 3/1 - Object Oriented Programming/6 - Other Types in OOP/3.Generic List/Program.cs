using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3.Generic_List
{
    class Program
    {
        static void Main()
        {
            GenericList<int> numbers = new GenericList<int>()
            {
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            };
            Console.WriteLine("Creating a GenericList with the numbers from 1 to 20 \n {0} \n", numbers);

            numbers.Remove(19);
            Console.WriteLine("Removing the 19th element \n {0} \n", numbers);

            numbers.Add(100);
            Console.WriteLine("Adding an element to the end of the GenericList \n {0} \n", numbers);

            numbers.Insert(30, 10);
            Console.WriteLine("Inserting an element on the 10th position \n {0} \n", numbers);

            numbers[3] = 9;
            Console.WriteLine("Changing the value of the 3rd index number \n {0} \n", numbers);

            Console.WriteLine("Trying to find number 4 \n Number Found: {0}, Found At: {1} \n", numbers.Contains(4), numbers.Find(4));
            Console.WriteLine("Trying to find number 80 \n Number Found: {0}, Found At: {1} \n", numbers.Contains(80), numbers.Find(80));
            Console.WriteLine("Min element: {0}, Max element: {1} \n", numbers.Min(), numbers.Max());

            numbers.Clear();
            Console.WriteLine("Cleared GenericList: \n {0} \n", numbers);

            Type type = typeof(GenericList<>);
            VersionAttribute attribute = (VersionAttribute)type.GetCustomAttributes(false).LastOrDefault();
            Console.WriteLine("Version: " + attribute.Version);

        }
    }
}
