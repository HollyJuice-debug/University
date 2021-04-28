using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }
    class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Sex { get; set; }


        public Person(string name, int age, Gender sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }


        /// <summary>
        /// Лет до пенсии
        /// </summary>
        /// <returns></returns>
        public int GetYearsBeforeRetirementAge()
        {
            if(Sex == Gender.Female)
            {
                int ageDifference = 57 - Age;
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
                int ageDifference = 62 - Age;
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
                int ageDifference = 60 - Age;
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
        /// <summary>
        /// Период возраста
        /// </summary>
        /// <returns></returns>
        public string GetAgePeriodization()
        {
            if (Age == 0) return "Грудной ребёнок";
            if (Age == 1 || Age == 2) return "Раннее детство";
            if (Age >= 3 && Age <= 7) return "Первый период детства";

            if(Sex == Gender.Male)
            {
                if (Age >= 8 && Age <= 12) return "Второй период детства";
                if (Age >= 13 && Age <= 16) return "Подростковый возраст";
                if (Age >= 17 && Age <= 21) return "Юношеский возраст";
                if (Age >= 22 && Age <= 60) return "Средний возраст";
                if (Age >= 61 && Age <= 75) return "Пожилой человек";
            }

            if (Sex == Gender.Female)
            {
                if (Age >= 8 && Age <= 11) return "Второй период детства";
                if (Age >= 12 && Age <= 15) return "Подростковый возраст";
                if (Age >= 16 && Age <= 20) return "Юношеский возраст";
                if (Age >= 21 && Age <= 55) return "Средний возраст";
                if (Age >= 56 && Age <= 75) return "Пожилой человек";
            }
            if (Age >= 76 && Age <= 90) return "Старческий возраст";
            if (Age > 90) return "Долгожитель";

            return "Неверный возраст";
        }
        /// <summary>
        /// Год рождения
        /// </summary>
        /// <returns></returns>
        public int YearOfBirth()
        {
            return DateTime.Now.Year - Age;
        }
    }


    /// <summary>
    /// Преподаватель
    /// </summary>
    class Teacher : Person
    {
        /// <summary>
        /// Стаж работы
        /// </summary>
        public int WorkExperience { get; set; }

        /// <summary>
        /// Научных работ
        /// </summary>
        public int ScientificPapersCount { get; set; }

        public int EducatesStudents { get; set; }

        /// <summary>
        /// Отношение стажа работы к возрасту
        /// </summary>
        /// <returns></returns>
        public double GetPercentageOfWorkExperienceByAge()
        {
            return ((double)(WorkExperience) / Age) * 100;
        }
        /// <summary>
        /// Научных работ в год за период работы
        /// </summary>
        /// <returns></returns>
        public double GetScientificPapersPerWorkYear()
        {
            return (double)ScientificPapersCount / WorkExperience;
        }
        /// <summary>
        /// Год начала работы
        /// </summary>
        /// <returns></returns>
        public int GetCareerStartYear()
        {
            return DateTime.Now.Year - WorkExperience;
        }

        /// <summary>
        /// Преподаватель
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="sex">Пол</param>
        /// <param name="workExperience">Стаж работы</param>
        /// <param name="scientificPapersCount">Кол-во научных работ</param>
        /// <param name="educatesStudents">Кол-во обучаемых студентов</param>
        public Teacher(string name, int age, Gender sex, int workExperience, int scientificPapersCount, int educatesStudents) : base(name, age, sex)
        {
            WorkExperience = workExperience;
            ScientificPapersCount = scientificPapersCount;
            EducatesStudents = educatesStudents;
        }


    }
    class HeadOfDepartment
    {
        /// <summary>
        /// Преподавателей в подчинении
        /// </summary>
        public int SubordinateTeachers { get; set; }
        /// <summary>
        /// Издано учебных материалов
        /// </summary>
        public int TextbooksPublished { get; set; }
        /// <summary>
        /// Сумма полученных грантов
        /// </summary>
        public double AmountOfGrantsReceived { get; set; }

    }
    class Student
    {
        /// <summary>
        /// Средняя оценка
        /// </summary>
        public double AverageRating { get; set; }

        /// <summary>
        /// Год обучения
        /// </summary>
        public int CourseNumber { get; set; }

        /// <summary>
        /// Обучение на коммерческой основе
        /// </summary>
        public bool Commerce { get; set; }
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
