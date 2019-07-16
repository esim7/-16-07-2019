using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            var country = new Country();
            Pole[] pole = new Pole[4];
            
            int key;
            do
            {    
                Console.Clear();
                Console.WriteLine("1. Создание страны \n2. Создание поля \n3. Изменение\n4. Удаление \n5. Поиск по имени ");
                Console.SetCursorPosition(40, 2);
                Console.WriteLine(country.GetName());
                Console.SetCursorPosition(40, 3);
                Console.WriteLine(country.GetInfo());
                Console.SetCursorPosition(10, 10);
                Console.SetCursorPosition(0, 7);
                if (int.TryParse(Console.ReadLine(), out key))
                {
                    switch (key)
                    {
                        case 1:
                            {
                                string temp;
                                Console.WriteLine("Введите название страны");
                                temp = Console.ReadLine();
                                country.SetName(temp);
                                Console.WriteLine("Введите информацию про данную страну");
                                temp = Console.ReadLine();
                                country.SetInfo(temp);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("В стране " + country.GetName() + " распологается 4 поля");
                                for(int i = 0; i<pole.Length; i++)
                                {
                                    Console.WriteLine("Введите название культуры которая растет на " + (i + 1) + " поле");
                                    string temp;
                                    temp = Console.ReadLine();
                                    pole[i].SetTypeCroops(temp);
                                }
                                break;
                            }
                        case 3:
                            {

                                break;
                            }
                        case 4:
                            {

                                break;
                            }
                        case 5:
                            {
                                string temp;
                                Console.WriteLine("Введите название культуры для поиска");
                                temp = Console.ReadLine();
                                for(int i = 0; i<pole.Length; i++)
                                {
                                    int index = pole[i].GetTypeCroops().IndexOf(temp); 
                                    Console.WriteLine(index);
                                }
                                break;
                            }
                        default:
                            Console.WriteLine("Введена неверная команда");
                            break;

                    }
                }

                else

                {

                    Console.WriteLine("Ошибка, неверная команда!!!");

                }
                

                Console.ReadLine();

            } while (key != 0);
        }
    }
}
