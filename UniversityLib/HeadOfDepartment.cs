namespace University
{
    /// <summary>
    /// Заведующий кафедрой
    /// </summary>
    public class HeadOfDepartment : Person
    {
        /// <summary>
        /// Заведующий кафедрой
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="sex"Пол></param>
        /// <param name="subordinateTeachers">Преподователей в подчинении</param>
        /// <param name="textbooksPublished">Издано учебных материалов</param>
        /// <param name="amountOfGrantsReceived">Сумма полученных грантов</param>
        public HeadOfDepartment(string name, int age, Gender sex, int subordinateTeachers, int textbooksPublished, double amountOfGrantsReceived) : base(name, age, sex)
        {
            SubordinateTeachers = subordinateTeachers;
            TextbooksPublished = textbooksPublished;
            AmountOfGrantsReceived = amountOfGrantsReceived;
        }

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

        public Teacher BestTeacher { get; set; } = null;

        /// <summary>
        /// Соотношение опубликованных учебных материалов к количество преподавателей
        /// </summary>
        /// <returns></returns>
        public double TextbooksPublishedPerTeacher()
        {
            return ((double)TextbooksPublished / SubordinateTeachers);
        }

        /// <summary>
        /// Средняя сумма грантов на преподавателя
        /// </summary>
        /// <returns></returns>
        public double AmountOfGrantsReceivedPerTeacher()
        {
            return ((double)AmountOfGrantsReceived / SubordinateTeachers);
        }
        /// <summary>
        /// Соотношение суммы грантов к количеству опубликованных учебников
        /// </summary>
        /// <returns></returns>
        public double RatioGrantsOfPublishedTextbooks()
        {
            return ((double)(AmountOfGrantsReceived) / TextbooksPublished);
        }

        /// <summary>
        /// Информация о зав.кафедрой в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"\nПреподователей в подчинении: {SubordinateTeachers} лет\n" +
                $"Издано учебных материалов: {TextbooksPublished}\n" +
                $"Сумма полученных грантов: {AmountOfGrantsReceived} руб.";
        }
        public override bool IsContains(string text)
        {
            text = text.ToUpper();
            if (SubordinateTeachers.ToString().Contains(text)
                || TextbooksPublished.ToString().Contains(text)
                || AmountOfGrantsReceived.ToString().Contains(text)
                || Name.ToUpper().Contains(text)
                || Age.ToString().Contains(text)
                || Sex.ToString().Contains(text)) return true;
            else return false;
        }
    }
}
