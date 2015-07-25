using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Hristiyan";
        string lastName = "Mishinkov";
        byte age = 20;
        char gender = 'М';
        ulong idNum = 8306112507;
        ushort uniqueNum = 9999;

        Console.WriteLine("Name:{0} {1} \t\t {2},{3} years old", firstName, lastName, gender, age);
        Console.WriteLine("ID Number: {0} \t\t\t Unique Number: 2756{1}", idNum, uniqueNum);
    }
}