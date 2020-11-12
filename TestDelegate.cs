using System.Collections.Generic;
namespace DelegateApp
{
    public class TestDelegate
    {
        public string Space(string str)
        {
            string spaceBtw = "";
            foreach (var item in str)
            {
                spaceBtw += item + " ";
            }
            return spaceBtw;
        }

        public string Reverse( string str )
        {
            string result = "";
            Stack<char> reverser = new Stack<char>(); // with the knowledge of LIFO
            foreach (var item in str)
            {
                reverser.Push(item);
            }
            foreach (var item in reverser)
            {
                result += item;
            }
            return result;
        }
    }
}