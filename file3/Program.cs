using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан файл целых чисел. Заменить в нем каждый элемент с четным номером на два нуля.
            string input = "C:\\Users\\Ilnaz.Farhullin\\Desktop\\file\\test3.txt";
            string output = "C:\\Users\\Ilnaz.Farhullin\\Desktop\\file\\test4.txt";

            StreamReader sr = new StreamReader(input);  
            StreamWriter sw = new StreamWriter(output);
            string line;
            int lineNum = 1;
            while ((line = sr.ReadLine()) != null)
            {
                int number  = Convert.ToInt32(line);
                if (lineNum % 2 ==0)
                {
                    number = 0;

                }
                sw.WriteLine(number);
                lineNum++;  
            }
            sr.Close();
            sw.Close();
            Console.WriteLine("Замена выполнена");
            Console.ReadKey();

        }
    }
}
