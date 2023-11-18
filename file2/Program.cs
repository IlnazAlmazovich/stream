using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader f = new StreamReader("C:\\Users\\Ilnaz.Farhullin\\Desktop\\file\\test2.txt");
                string s;
                if ((s = f.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    while ((s = f.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    f.Close();

                }
                else
                {
                    Console.WriteLine("Файл пустой!!!");
                }
               
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Проверьте имя" + e.Message);
                return;
            }
            Console.ReadKey();

        }
    }
}
