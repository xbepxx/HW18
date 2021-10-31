using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с разным типом скобок");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str) ? "Количество скобок совпадает" : "Количество скобок не совпадает");
            Console.ReadKey();
        }
        static bool Check(string str)
        {
            Stack<char> st = new Stack<char>();
            var sk = new Dictionary<char, char>
            {
                {')','('},
                {'}','{'},
                {']','['},
            };
            foreach (var n in str)
            {
                if (n == '[' || n == '(' || n == '[')
                    st.Push(n);
                if (n == ']' || n == ')' || n == ']')
                {
                    if (st.Count == 0 || st.Pop() != sk[n])
                        return false;
                }
            }
            if (st.Count != 0)
                return false;
            return true;
        }
    }
}
