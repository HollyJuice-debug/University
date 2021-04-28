using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{

    public enum Gender
    {
        Male,
        Female
    }
    class Person
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private Gender sex;

        public Person(string name, int age, Gender sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public Gender Sex
        {
            get { return sex; }
            set { sex = value; }
        }


        public int GetYearsBeforeRetirementAge()
        {
            if(Sex == Gender.Female)
            {
                int ageDifference = 57 - age;
                if (ageDifference > 0)
                {
                    return ageDifference;
                }
                else
                {
                    return 0;
                }
            }
            else if(Sex == Gender.Male)
            {
                int ageDifference = 62 - age;
                if (ageDifference > 0)
                {
                    return ageDifference;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                int ageDifference = 60 - age;
                if (ageDifference > 0)
                {
                    return ageDifference;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string GetAgePeriodization()
        {
            if (age == 0) return "Грудной ребёнок";
            if (age == 1 || age == 2) return "Раннее детство";
            if (age >= 3 && age <= 7) return "Первый период детства";

            if(Sex == Gender.Male)
            {
                if (age >= 8 && age <= 12) return "Второй период детства";
                if (age >= 13 && age <= 16) return "Подростковый возраст";
                if (age >= 17 && age <= 21) return "Юношеский возраст";
                if (age >= 22 && age <= 60) return "Средний возраст";
                if (age >= 61 && age <= 75) return "Пожилой человек";
            }

            if (Sex == Gender.Female)
            {
                if (age >= 8 && age <= 11) return "Второй период детства";
                if (age >= 12 && age <= 15) return "Подростковый возраст";
                if (age >= 16 && age <= 20) return "Юношеский возраст";
                if (age >= 21 && age <= 55) return "Средний возраст";
                if (age >= 56 && age <= 75) return "Пожилой человек";
            }
            if (age >= 76 && age <= 90) return "Старческий возраст";
            if (age > 90) return "Долгожитель";

            return "Неверный возраст";
        }
        public int YearOfBirth()
        {
            return DateTime.Now.Year - age;
        }
    }

    public enum AcademicPosition
    {
        GraduateStudent,
        ResearchAssociate,
        Assistant,
        Teacher,
        LeadingResearcher,
        Professor,
        ChiefResearchOfficer,
        SeniorLecturer,
        DoctoralStudent,
        Trainee,
        AssociateProfessor,
        SeniorResearcher,
        JuniorResearcher
    }
    class Teacher : Person
    {
        private int workExperience;

        public int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        private int scientificPapersCount;

        public int ScientificPapersCount
        {
            get { return scientificPapersCount; }
            set { scientificPapersCount = value; }
        }

        private int educatesStudents;

        public int EducatesStudents
        {
            get { return educatesStudents; }
            set { educatesStudents = value; }
        }


        public double GetPercentageOfWorkExperienceByAge()
        {
            return ((double)(WorkExperience) / Age) * 100;
        }
        public double GetScientificPapersPerWorkYear()
        {
            return (double)ScientificPapersCount / WorkExperience;
        }
        public int GetCareerStartYear()
        {
            return DateTime.Now.Year - WorkExperience;
        }

        public Teacher(string name, int age, Gender sex, int workExperience, int scientificPapersCount, AcademicPosition position) : base(name, age, sex)
        {
            WorkExperience = workExperience;
            ScientificPapersCount = scientificPapersCount;
            Position = position;
        }


    }
    class HeadOfDepartment
    {
        private int subordinateTeachers;

        public int SubordinateTeachers
        {
            get { return subordinateTeachers; }
            set { subordinateTeachers = value; }
        }

    }
    class Student
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Саня", 31, Gender.Male, 5, 6, AcademicPosition.Teacher);
            Console.WriteLine(teacher.GetPercentageOfWorkExperienceByAge());
        }
    }
}
