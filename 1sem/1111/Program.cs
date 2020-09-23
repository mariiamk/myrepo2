using System;

namespace Application
{
    /*
    Добавьте в решение новый проект с именем ASCIIDecoder. Получать от пользователя целое
    число Code из диапазона от 32 до 127 (считать входные данные корректными).
    Выводить на экран изображение символа, представленное в таблице кодов ASCII кодом
    Code. При выполнении задания использовать методы преобразования строк в целые
    типы и операцию приведения типа.
    */

    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            if (!int.TryParse(Console.ReadLine(), out n)
                || n < 32
                || n > 127)
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine((char)n);

        }
    }
}
