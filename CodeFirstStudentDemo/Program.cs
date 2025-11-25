using System;

namespace CodeFirstStudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    Name = "Amin",
                    Age = 25
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student has been added to the database.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
