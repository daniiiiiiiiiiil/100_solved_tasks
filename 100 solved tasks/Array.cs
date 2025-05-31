using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    internal class Array
    {
        public void even_numbers()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    MessageBox.Show(array[i].ToString());
                }
            }
        }
        public void number_of_vowels(string word)
        {
            int count = 0;
            char[] arr= { 'а', 'е', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                        count++;
                }
            }
            MessageBox.Show(count.ToString());
        }
        public void palindromes(string word)
        {
            bool s = true;
            string revers = new string(word.Reverse().ToArray());
            if(word == revers)
                s = true;
            else 
                s = false;
            MessageBox.Show(s.ToString());
        }
        public void order(string word)
        {
            string[] words = word.Split(' ');
            string s = new string(words.Reverse().ToArray());
            string reversed = string.Join(" ", s);
            MessageBox.Show(reversed);
        }
    }
}
