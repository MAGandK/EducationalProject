using System;

namespace Lesson5.Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            CurriculumVitae cv = new CurriculumVitae("Ann","Migitenko", 33, "economy", 0);

            cv.GetInfo();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            cv.Age = age;

            Console.Write("Enter your education: ");
            string education = Console.ReadLine();
            cv.Educations = education;

            Console.Write("Enter your professionalSkills: ");
            double professionalSkills = Convert.ToInt32(Console.ReadLine());
            cv.ProfessionalSkills = professionalSkills;

            Console.Write("Enter your name University: ");
            string nameUniv = Console.ReadLine();
            cv.NameUniversity(nameUniv);

            cv.ShowInformation();

            Console.WriteLine(cv.CalculateRelevance());
        }
    }
}