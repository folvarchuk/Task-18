using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        /*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки. 
         *Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; 
         *для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека 
         *(при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую три вида скобок:");
            string symbols = Console.ReadLine();
            if (Check(symbols) == true)
                Console.WriteLine("Скобки расставлены корректно.");
            else
                Console.WriteLine("Скобки расставлены некорректно.");
            Console.ReadKey();
        }
        static bool Check(string symbols)
        {
            Stack<char>stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                {'(', ')' },
                {'[', ']' },
                {'{', '}' }
            };
            foreach(char c in symbols)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(brackets[c]);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count==0)
                return true;
            else
                return false;
        }
    }
}
