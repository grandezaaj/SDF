using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int TotalGP { get; set; }
            public int CreditHoursAttempted { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Rody Duterte", TotalGP = 5, CreditHoursAttempted = 5 });
            students.Add(new Student { Name = "Grace Poe", TotalGP = 10, CreditHoursAttempted = 5 });
            students.Add(new Student { Name = "Mar Roxas", TotalGP = 3, CreditHoursAttempted = 0 });

            int GPA = 0;
            foreach (var student in students)
            {
                try
                {
                    GPA = student.TotalGP / student.CreditHoursAttempted;
                }
                catch (DivideByZeroException)
                {
                    GPA = 0;
                }
                finally
                {
                    Console.WriteLine(String.Format("{0}:{1}", student.Name, GPA));
                }
            }

            Console.ReadKey();
        }
    }


}
