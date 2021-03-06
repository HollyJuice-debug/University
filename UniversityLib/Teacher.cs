using System;

namespace University
{
    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher : Person
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
        /// <summary>
        /// Информация о преподавателе в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"\nСтаж: {WorkExperience} лет\nКол-во научных работ: {ScientificPapersCount}\nКол-во обучаемых студентов: {EducatesStudents}";
        }

        public override bool IsContains(string text)
        {
            text = text.ToUpper();
            if (WorkExperience.ToString().Contains(text)
                || ScientificPapersCount.ToString().Contains(text)
                || EducatesStudents.ToString().Contains(text)
                || Name.ToUpper().Contains(text)
                || Age.ToString().Contains(text)
                || Sex.ToString().Contains(text)) return true;
            else return false;
        }
    }
}
