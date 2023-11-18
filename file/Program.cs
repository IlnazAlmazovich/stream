using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Необходимо записать в файл рандомные числа
            try
            {
                StreamWriter f = new StreamWriter("C:\\Users\\Ilnaz.Farhullin\\Desktop\\file\\test4.txt"); //создаём поток и помещаем туда путь к файлу
                f.WriteLine("Вывод в текстовый файл"); //записывет введённый текст в текстовый поток 
                Random r = new Random(); // создаётся класс рандом
                int a; // создаём переменную которая будет хранить рандомные числа
                for (int i = 0; i < 10; i++) //цикл фор. указываем параметр до 10 чисел
                {
                    a = r.Next(100);// определяем диапазон чисел
                    f.WriteLine(a);// выводи числа в файл
                     Console.WriteLine(a);// выводим числа в консоль
                }
                f.Close(); // закрываем поток
                Console.WriteLine("Запись выполнена");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                return;
            }



            //FileInfo fileInfo = new FileInfo(path);
            //if (fileInfo.Exists)
            //{
            //    Console.WriteLine("Имя файла: {0}", fileInfo.Name);
            //    Console.WriteLine("Время создания файла: {0}", fileInfo.CreationTime);
            //    Console.WriteLine("Размер: {0}", fileInfo.Length);
            //}

            Console.ReadKey();
        }
    }
}
