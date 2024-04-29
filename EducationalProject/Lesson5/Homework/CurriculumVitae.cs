using System;
namespace Lesson5.Homework
{
    public class CurriculumVitae
    {
        public const string Company = "TimDevelipers";
        public const string Item = "Junior Developer";

        public string name;
        public string surname;
        private int _age;
        private string _education;
        private double _professionalSkills;
        private string _university;
        private string _courses;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (value >=18)
                {
                    Console.WriteLine("You are suitable for a junior position");
                }
                else
                {
                    Console.WriteLine("Only from 18");
                }
            }
        }

        public double ProfessionalSkills 
        {
            get { return _professionalSkills; }
            set
            {
                _professionalSkills = value;
                if (_professionalSkills < 1)
                {
                    Console.WriteLine("Have you completed any courses? Which? ");
                    string courses = Console.ReadLine();
                    _courses = courses;
                }
            }
        }

        public string University
        {
            get { return _university; }
            set { _university = value; }
        }

        public string Educations 
        {
            get { return _education; }
            set { _education = value; }
        }

        public CurriculumVitae(string name, string surname) 
        {
            this.name = name;
            this.surname = surname;
        }

        public CurriculumVitae(string name, string surname, int age) 
        {
            this.name = name;
            this.surname = surname;
            _age = age;
        }

        public CurriculumVitae(string name, string surname, int age,
            string education, double professionalSkills) 
        {
            this.name = name;
            this.surname = surname;
            _age = age;
            _education = education;
            _professionalSkills = professionalSkills;
            _university = " ";
        }

        public void GetInfo()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            this.name = name;

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            this.surname = surname;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Education: {_education}");
            Console.WriteLine($"Professional Skills: {_professionalSkills}");
            Console.WriteLine($"Name University: {_university}");
            if (_courses != null)
            {
                Console.WriteLine($"Name courses: {_courses}");
            }
        }

        public void NameUniversity(string nameUniv)
        {
            _university = nameUniv;
        }

        public double CalculateRelevance()
        {
            double relevance = 0;

            if (name !=null || surname != null)
            {
                relevance += 0.2;
            }
            if (_professionalSkills > 1)
            {
                relevance += 0.5;
            }
            if (_courses != null)
            {
                relevance += 0.3;
            }

            return relevance;
        }
    }
}