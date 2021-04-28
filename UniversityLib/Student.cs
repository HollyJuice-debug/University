using System;

namespace University
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student : Person
    {
        public Student(string name, int age, Gender sex, double averageRating, int courseNumber, bool commerce) : base(name, age, sex)
        {
            AverageRating = averageRating;
            CourseNumber = courseNumber;
            Commerce = commerce;
        }

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

        /// <summary>
        /// Год начала обучения
        /// </summary>
        /// <returns></returns>
        public int GetYearOfStartOfEducation()
        {
            return DateTime.Now.Year - CourseNumber;
        }
        /// <summary>
        /// Год завершения обучения
        /// </summary>
        /// <returns>Год</returns>
        public int GetYearOfCompletionOfEducation()
        {
            return GetYearOfStartOfEducation() + 4;
        }

        /// <summary>
        /// Отличие средней оценки студента от средней оценки други студентов
        /// </summary>
        /// <returns></returns>
        public double DifferenceWithAverageStudentsRating()
        {
            return AverageRating - 3.7;
        }
    }
}
