using System;

namespace Seminar2DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите цифру обозначающую день недели:");
           int chislo = int.Parse(Console.ReadLine());
           /*switch (chislo)
           {
            case 6:
                 Console.WriteLine("Выходной день!");
                 break;
            case 7:
                 Console.WriteLine("Выходной день!");
                 break;
            default:  
                Console.WriteLine("Будний день!");
                break;
           }*/
           if (chislo == 6 || chislo == 7)
           {
              Console.WriteLine("Выходной день!");
           }
           else if (chislo>=1 && chislo<=7)
           {
             Console.WriteLine("Будний день!");
           }
           else 
           {
             Console.WriteLine("Вы ввели некорректную цифру!");
           }
        }
    }
}
