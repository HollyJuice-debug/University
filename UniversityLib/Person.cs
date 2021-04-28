using System;

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


    /// <summary>
    /// Персона
    /// </summary>
    public class Person
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


        /// <summary>
        /// Персона
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="sex">Пол</param>
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
}
