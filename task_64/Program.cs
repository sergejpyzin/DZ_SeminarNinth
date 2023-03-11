namespace task_64
{
    internal class Program
    {
        static int GetNumberUserMassedge(string userMassedge)
        {
            int userNumber = 0;
            while (true)
            {
                Console.Write(userMassedge);
                bool check = int.TryParse(Console.ReadLine(), out userNumber);
                if (check) return userNumber;
                else Console.WriteLine("Ошибка! Попробуйте еще раз.");
            }
        }

        static void NaturalNumber(int number)
        {
            if (number <= 0) return;
            Console.WriteLine(number);
            NaturalNumber(number - 1);
        }
//          Задача 64: Задайте значение N.
//          Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//          N = 5 -> "5, 4, 3, 2, 1"
//          N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
        static void Main(string[] args)
        {
            int number = GetNumberUserMassedge("Введите число: ");
            NaturalNumber(number);
        }
    }
}