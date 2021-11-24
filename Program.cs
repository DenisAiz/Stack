using System;
using static Task2.Stack;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var stackData = new Stack();
            stackData.Notify += new Message(Request);

            Console.WriteLine("Заполните стек:");

            for (int i = 0; i < 5; i++)
            {
                var word = Console.ReadLine();
                stackData.Push(word);
            }

            Console.WriteLine("1. Добавить элемент");
            Console.WriteLine("2. Удалить последний элемент");
            Console.WriteLine("3. Показать весь стек");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Выберите действие: ");

                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Элемент: ");
                        string line = Console.ReadLine();

                        stackData.Push(line);
                        break;

                    case 2:
                        stackData.Pop();
                        break;

                    case 3:
                        var list = stackData.Show();
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    default:
                        Console.WriteLine("\t\n---- Error ----\n");
                        break;
                }
            }
        }

        public static void Request(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
