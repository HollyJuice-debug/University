using System;
using System.Collections.Generic;

namespace University
{
    /// <summary>
    /// Меню программы
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Хранилище персон
        /// </summary>
        static List<Person> persons = new List<Person>();

        /// <summary>
        /// Инициализация хранилища персон тестовыми данными
        /// </summary>
        public Menu()
        {
            Student student = new Student("Путин В.В.", 20, Gender.Male, 4.3, 2, false);
            Teacher teacher = new Teacher("Анатолий И.А.", 29, Gender.Male, 6, 4, 125);
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("Сергей М.В.", 29, Gender.Male, 6, 12, 590000);

            persons.Add(student);
            persons.Add(teacher);
            persons.Add(headOfDepartment);
        }

        /// <summary>
        /// Запуск меню
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Просмотр персон");
                Console.WriteLine("2. Добавить персону");
                Console.WriteLine("3. Поиск");
                Console.WriteLine("4. Выход");
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1': PrintPersons(); break;
                    case '2': AddPersons(); break;
                    case '3': SearchPersons(); break;
                    case '4': Environment.Exit(0); break;
                    default: break;
                }
            }
        }
        /// <summary>
        /// Вывод персон
        /// </summary>
        public static void PrintPersons()
        {
            Console.Clear();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
                Console.WriteLine("========================================");
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// Добавление персон
        /// </summary>
        public static void AddPersons()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите вариант:");
                Console.WriteLine("1. Студент");
                Console.WriteLine("2. Преподаватель");
                Console.WriteLine("3. Заведующий кафедрой");
                choice = Console.ReadKey(true).KeyChar;
            }
            while (choice != '1' && choice != '2' && choice != '3');

            switch (choice)
            {
                case '1'://Student
                    {
                        string name = "";
                        int age = 0;
                        Gender sex;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите возраст: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out age) || age < 0);

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите пол: ");
                            Console.WriteLine("1. Мужской");
                            Console.WriteLine("2. Женский");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (c == 1) { sex = Gender.Male; break; }
                            else if (c == 2) { sex = Gender.Female; break; }
                        }


                        double averageRating = 0.0;
                        int courseNumber = 0;
                        bool commerce = false;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите среднею оценку: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out averageRating) || averageRating <= 0 || averageRating > 5);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите курс: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out courseNumber) || courseNumber <= 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Обучается ли на коммерции: ");
                        }
                        while (!bool.TryParse(Console.ReadLine(), out commerce));

                        persons.Add(new Student(name, age, sex, averageRating, courseNumber, commerce)); break;
                    }
                case '2'://Преподаватель
                    {
                        string name = "";
                        int age = 0;
                        Gender sex;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите возраст: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out age) || age < 0);

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите пол: ");
                            Console.WriteLine("1. Мужской");
                            Console.WriteLine("2. Женский");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (c == 1) { sex = Gender.Male; break; }
                            else if (c == 2) { sex = Gender.Female; break; }
                        }

                        int workExperience;
                        int scientificPapersCount;
                        int educatesStudents;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите стаж: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out workExperience) || workExperience < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во научных работ: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out scientificPapersCount) || scientificPapersCount < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во обучаемых студентов: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out educatesStudents) || educatesStudents < 0);


                        persons.Add(new Teacher(name, age, sex, workExperience, scientificPapersCount, educatesStudents)); break;
                    }
                case '3'://Зав.кафедры
                    {
                        string name = "";
                        int age = 0;
                        Gender sex;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите возраст: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out age) || age < 0);

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите пол: ");
                            Console.WriteLine("1. Мужской");
                            Console.WriteLine("2. Женский");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (c == 1) { sex = Gender.Male; break; }
                            else if (c == 2) { sex = Gender.Female; break; }
                        }

                        int subordinateTeachers;
                        int textbooksPublished;
                        double amountOfGrantsReceived;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во преподавателей в подчинении: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out subordinateTeachers) || subordinateTeachers < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во изданных научных материалов: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out textbooksPublished) || textbooksPublished < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите сумму полученных грантов: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out amountOfGrantsReceived) || amountOfGrantsReceived < 0);


                        persons.Add(new HeadOfDepartment(name, age, sex, subordinateTeachers, textbooksPublished, amountOfGrantsReceived)); break;
                    }
                default: throw new Exception("Ошибка");
            }
        }

        /// <summary>
        /// Поиск персон по заданной строке
        /// </summary>
        public static void SearchPersons()
        {
            Console.Clear();
            Console.Write("Введите строку для поиска: ");
            string searchText = Console.ReadLine();
            Console.WriteLine("========================================");

            foreach (var item in persons)
            {
                if (item.IsContains(searchText))
                {
                    Console.WriteLine(item);
                    Console.WriteLine("========================================");
                }
            }
            Console.ReadKey(true);
        }
    }
}
