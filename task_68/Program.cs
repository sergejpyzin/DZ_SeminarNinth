namespace task_68
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

        static int GetFunctionAkkerman(int numberM, int numberN)
        {
            if (numberM == 0) return numberN + 1;
            if (numberM > 0 && numberN == 0) return GetFunctionAkkerman(numberM - 1, 1);
            if (numberM > 0 && numberN > 0) return GetFunctionAkkerman(numberM - 1, GetFunctionAkkerman(numberM, numberN -1));
            return GetFunctionAkkerman(numberM, numberN);
        }
        //        Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
        //        Даны два неотрицательных числа m и n.
        //        m = 2, n = 3->A(m, n) = 9
        static void Main(string[] args)
        {
            int numberM = GetNumberUserMassedge("Введите число М: ");
            int numberN = GetNumberUserMassedge("Введите число N: ");
            int functionAkkerman = GetFunctionAkkerman(numberM, numberN);
            Console.WriteLine(functionAkkerman);
        }
    }
}