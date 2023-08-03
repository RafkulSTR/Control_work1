namespace Control_work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива через пробел: ");
            string input = Console.ReadLine();

            string[] array = input.Split(' ');

            Console.WriteLine(string.Join(",", array));

        }

        static string[] FilterArray(string[] array)
        {
           

            return null;
        }
    }
}