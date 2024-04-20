using System;
using static System.Console;

namespace Module13AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message and storing the number of students
            Write("Welcome, please list the number of students you would like to enter: ");
            int numOfStudents = Convert.ToInt32(ReadLine());

            //Creating array of students
            Student[] studentArray = new Student[numOfStudents];

            //Populating the array of students
            for (int x = 0; x < studentArray.Length; x++)
            {
                populateStudent(ref studentArray[x]);
            }

            //Storing number of teachers and creating the array
            Write("Please list the number of teachers you would like to enter: ");
            int numOfTeachers = Convert.ToInt32(ReadLine());
            Teacher[] teacherArray = new Teacher[numOfStudents];

            //Populating array of teachers
            for (int y = 0; y < numOfTeachers; y++)
            {
                populateTeacher(ref teacherArray[y]);
            }

            //Printing out students
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("{0,70}", "----------STUDENTS----------");
            WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}", "IDNumber", "Name", "Address", "Major", "Advisor");
            ForegroundColor = ConsoleColor.Gray;
            for (int z = 0; z < numOfStudents; z++)
            {
                WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}", studentArray[z].IDNumber, studentArray[z].FullName, studentArray[z].Address, studentArray[z].Major, studentArray[z].Advisor);
            }

            //Printing out teachers
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("{0,70}", "----------TEACHERS----------");
            WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}", "IDNumber", "Name", "Address", "Salary", "Years Taught");
            ForegroundColor = ConsoleColor.Gray;
            for (int z = 0; z < numOfTeachers; z++)
            {
                WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}", teacherArray[z].IDNumber, teacherArray[z].FullName, teacherArray[z].Address, "$"+teacherArray[z].Salary+"/year", teacherArray[z].YearsOfService);
            }

            static void populateStudent(ref Student s) 
            {
                Write("Please enter the ID number of the student: ");
                int idNumber = Convert.ToInt32(ReadLine());

                Write("Please enter the full name of the student: ");
                string fullName = ReadLine();

                Write("Please enter the address of the student: ");
                string address = ReadLine();

                Write("Please enter the major of the student: ");
                string major = ReadLine();

                Write("Please enter the advisor of the student: ");
                string advisor = ReadLine();

                s = new Student(idNumber, fullName, address, major, advisor);
            }

            static void populateTeacher(ref Teacher t)
            {
                Write("Please enter the ID number of the teacher: ");
                int idNumber = Convert.ToInt32(ReadLine());

                Write("Please enter the full name of the teacher: ");
                string fullName = ReadLine();

                Write("Please enter the address of the teacher: ");
                string address = ReadLine();

                Write("Please enter the annual salary of the teacher: ");
                decimal salary = Convert.ToDecimal(ReadLine());

                Write("Please enter the number of years the teacher has been teaching: ");
                int yearsOfService = Convert.ToInt32(ReadLine());

                t = new Teacher(idNumber, fullName, address, salary, yearsOfService);
            }
        }
    }
}
