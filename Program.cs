using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace LAST_PRAC_PRACTICE
{
    
    internal class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            string[] student = new string[SIZE];
            double[] marks = new double[SIZE];
            int nrStud = 0;
            int choice = Choice();
            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        Add_Student_and_Marks(student, marks, ref nrStud);
                        break;
                    case 2:
                        Display(student, marks,nrStud);
                        break;
                    case 3:
                        Find(student,marks,nrStud);
                        break;
                    case 4:
                        Delete(student,marks,ref nrStud);
                        break;
                }
                choice = Choice();
            }
            ReadLine();
        }
        static void Add_Student_and_Marks(string[]student, double[] marks,ref int nrStud)
        {
            if (nrStud < student.Length)
            {

                Write("Enter the name of the student: ");
                student[nrStud] = Console.ReadLine();
                Write("Enter students mark: ");
                marks[nrStud] = double.Parse(Console.ReadLine());
                nrStud++;
            }
            else
            {
                WriteLine("Student List is full");
            }
        }
        static void Display(string[]student, double[] marks,int nrStud)
        {
            for(int i = 0;i < nrStud; i++)
            {
                Write("The name of the students is: {0} ", student[i]);
                Write("The students marks is: {0} ", marks[i]);
                WriteLine();
            }
            if (nrStud == 0)
            {
                WriteLine("Can't display anything the list is empty");
            }
        }
        static void Find(string[] student, double[]marks ,int nrStud) 
        {
            Write("Which student are you looking for: ");
            string wanted=Console.ReadLine();
            for(int i = 0; i < nrStud; i++)
            {

                if (wanted == student[i])
                {
                    Write("The name of the students is: {0} ", student[i]);
                    Write("\nThe students marks is: {0} ", marks[i]);
                }
                else
                {
                    WriteLine("{0} was not found.",wanted);
                }
            }
            
            WriteLine();
        }
        static void Delete(string[] student, double[] marks,ref int nrStud)
        {
            Write("Which student do you want to remove: ");
            string name = Console.ReadLine();
            for(int i =0; i<nrStud-1;i++)
            {
                if(name == student[i])
                {
                    student[i]=student[i+1];
                }
                    nrStud--;  
            }
            Write("{0} has been removed",name);
           
        }
        static int Choice()
        {
            WriteLine();
            WriteLine("1. Add new students and their marks");
            WriteLine("2. Display all students and marks");
            WriteLine("3. Find a student");
            WriteLine("4. Delete a student and their mark");
            WriteLine("5. Exit the program");
            Write("Which option do you want: ");
            int option=Convert.ToInt32(Console.ReadLine());
          
            return option;
        }
    }
}
