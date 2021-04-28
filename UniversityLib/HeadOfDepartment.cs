namespace University
{
    /// <summary>
    /// Заведующий кафедрой
    /// </summary>
    public class HeadOfDepartment : Person
    {
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

    }
}
