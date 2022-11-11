using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        public enum ListOfCommand
        {
            FACTORIAL,
            SUM,
            MAX
        }

        public static void TextInput()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста, введите число итераций");
        }

        public static void MathematicProgram(ListOfCommand list)
        {
            string str = Console.ReadLine();
            int c1 = 1;
            int c2 = 0;
            int c3 = 0;

            if (str == "q")
            { return; }

            int iteration = Int32.Parse(str);


            for (int i = 1; i <= iteration; i++)
            {

                switch (list)
                {
                    case ListOfCommand.FACTORIAL:
                        {
                            c1 = c1 * i;
                            Console.WriteLine("Факториал равен " + c1);
                            break;
                        }

                    case ListOfCommand.SUM:
                        {
                            c2 = c2 + i;
                            Console.WriteLine("Сумма от 1 до N равна " + c2);
                            break;
                        }

                    case ListOfCommand.MAX:
                        {

                            if (i % 2 == 0)
                            {
                                c3 = i;
                            }
                            Console.WriteLine("Максимальное четное число меньше N равно " + c3);
                            break;
                        }

                    default: break;
                }
            }
        }


        public static void Main()
        {
            TextInput();
            MathematicProgram(ListOfCommand.FACTORIAL);
            Console.ReadLine();
        }
    }
}
