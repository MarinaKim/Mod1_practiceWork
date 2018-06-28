using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите номер задания: ");
            int n = 0;
            if (!Int32.TryParse(Console.ReadLine(), out n))
                {
                Console.WriteLine("Номер задания введен не корреткно! ");
            }

            switch (n)
            {
                /*5.	Написать приложение, которое выведет на экран Ваше имя и фамилию. (Жду что у вас будет приложение,
             *  которое я сам запущу и где у меня попросят ввести ФИО, после я нажму Enter и мне выдастся сообщение –
             *   «Приветствую тебя - ФИО»)*/
                case 1:
                    {
                        task1();
                    }break;

                /*6.	Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму. 
                 * (Так же как и в предыдущем примере, только с цифрами. Мы проходили как можно из строки перевести в число.)*/
                case 2:
                    {
                        task2();
                    }break;
            }
        }

        static void task1()
        {
            
            Console.Write("Введите ФИО: ");
            string fio = Console.ReadLine();
            Console.WriteLine("Приветсвую тебя, {0} ", fio);
        }

        static void task2 ()
        {
            Console.WriteLine("Введите количество чисел: ");
            int count = Int32.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < count; i++)
            {
                sum+= Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum: {0}", sum);
        }

    }
}
