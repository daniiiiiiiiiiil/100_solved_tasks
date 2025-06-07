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
        public void Counting_Letters(string word)
        {
            var letterCounts = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (letterCounts.ContainsKey(c))
                {
                    letterCounts[c]++;
                }
                else
                {
                    letterCounts[c] = 1;
                }
            }

            foreach (var kvp in letterCounts)
            {
                if (kvp.Value > 1)
                {
                    MessageBox.Show($"Буква: {kvp.Key} - повторяется {kvp.Value} раз(а).");
                }
            }
        }
    }
}
