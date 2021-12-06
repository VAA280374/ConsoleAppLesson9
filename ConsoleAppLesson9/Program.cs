using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, res = 0, zn = 0;
            bool _true = true;
            Console.WriteLine("Вас приветствует калькулятор");
            Console.Write("Введите целое число : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _true = false;
            }
            Console.WriteLine();
            if (_true)
            {
                Console.Write("Введите целое число : ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _true = false;
                }
            }
            if (_true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите код операции");
                Console.WriteLine("       1 - Сложение");
                Console.WriteLine("       2 - Вычитание");
                Console.WriteLine("       3 - Произведение");
                Console.WriteLine("       4 - Частное");
                Console.Write("Вашь выбор : ");
                try
                {
                    zn = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _true = false;
                }
                switch (zn)
                {
                    case 1 :
                        {
                            res = a + b;
                            break;
                        }
                    case 2 :
                        {
                            res = a - b;
                            break;
                        }
                    case 3 :
                        {
                            res = a * b;
                            break;
                        }
                    case 4 :
                        {
                            try
                            {
                                res = a / b;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                _true = false;
                            }
                            break;
                        }
                    default :
                        {
                            Console.WriteLine("Введено не верное значение");
                            _true = false;
                            break;
                        }

                }
                if (_true)
                {
                    Console.WriteLine("Ответ : {0}", res);
                }

                Console.ReadKey();

            }
        }
    }
}
