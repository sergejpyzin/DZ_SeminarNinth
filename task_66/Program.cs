namespace task_66
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

        static int SumNaturalNumber(int firstNumber, int secondNumber)
        {
            int sum = 0;
            if (secondNumber <= 0) throw new Exception("Введенное число {secondNumber} не являеться натуральным");
            if (firstNumber <= 0) throw new Exception("Введенное число {firstNumber} не являеться натуральным");
            if (firstNumber == secondNumber) return firstNumber;
            sum += secondNumber;
            return sum + SumNaturalNumber(firstNumber, secondNumber - 1);
        }
        //        Задача 66: Задайте значения M и N.
        //        Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //      M = 1; N = 15 -> 120
        //      M = 4; N = 8. -> 30
        static void Main(string[] args)
        {
            int m = GetNumberUserMassedge("Введите первое число: ");
            int n = GetNumberUserMassedge("Введите второе число: ");

            int summary = SumNaturalNumber(m, n);
            Console.WriteLine(summary); 
        }
    }
}