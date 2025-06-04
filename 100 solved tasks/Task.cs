using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    internal class Task
    {
        public bool simple(int number)
        {
            if(number < 2)
                return false;
            int limit = (int) Math.Sqrt(number);
            for(int i = 2;i<=limit;i++)
            {
                if(number % i ==0) return true;
            }
            return true;
        }
        public int CountingWords(string line)
        {
            string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public string Spaces(string line)
        {
            string replace = line.Replace(' ','-');
            return replace;
        }
    }
}
