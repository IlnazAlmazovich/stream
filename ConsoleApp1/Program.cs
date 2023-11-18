using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан файл целых чисел. Заменить в нем каждый элемент с четным номером на два нуля.
            // Путь к файлу
            string filePath = "C:\\Users\\Ilnaz.Farhullin\\Desktop\\file\\test3.txt";

            // Открываем файл для чтения
            StreamReader reader = new StreamReader(filePath);
            
                // Считываем первую строку
                string line = reader.ReadLine();

                // Создаем StringWriter для хранения измененных данных
                StringWriter writer = new StringWriter();

                // Переменная для отслеживания номера текущего элемента
                int count = 0;

                // Читаем файл до конца
                while (line != null)
                {
                    count++;

                    // Если номер элемента четный, заменяем на "00"
                    if (count % 2 == 0)
                    {
                        writer.WriteLine("00");
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                   Console.WriteLine(line);

                    // Считываем следующую строку
                    line = reader.ReadLine();
                }

                // Закрываем StreamReader
                reader.Close();

            // Записываем измененные данные обратно в файл
            StreamWriter writerToFile = new StreamWriter(filePath);
                
            writerToFile.Write(writer.ToString());
            writerToFile.Close();
            

            Console.WriteLine("Замена выполнена успешно.");
            
            Console.ReadKey();
        }
    }
}
    

