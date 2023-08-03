namespace Control_work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива через пробел: ");
            string input = Console.ReadLine();

            string[] array = input.Split(' ');

            Console.WriteLine("Новый массив:");
            Console.WriteLine(string.Join(", ", FilterArray(array)));

        }

        /// <summary>
        /// Формирование нового массива, менее трех символов
        /// </summary>
        /// <param name="array">Массив символов введеных пользователем</param>
        /// <returns>Готовый массив</returns>
        static string[] FilterArray(string[] array)
        {
            int newSize = 0;

            foreach (string element in array)
            {
                if (element.Length <= 3)
                {
                    newSize++;
                }
            }

            string[] filteredArray = new string[newSize];

            int index = 0;

            foreach (string element in array)
            {
                if (element.Length <= 3)
                {
                    filteredArray[index] = element;
                    index++;
                }
            }

            return filteredArray;
        }
    }
}