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
       public void Reverse_word_order(string word)
        {
            List<string> words = new List<string>(word.Split(' '));
            words.Reverse();
            string reversed = string.Join(" ", words);
            MessageBox.Show(reversed.ToString());
        }
        public void min()
        {
            int[] numbers = { 5, 2, 9, 1 };

            int min = numbers[0]; 

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            MessageBox.Show(min.ToString());
        }
        public void Delete()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4,3, 2, 5 };
            List<int> uniqueNumbers = numbers.Distinct().ToList();
            MessageBox.Show(string.Join(", ", uniqueNumbers));
        }
        public void sum(string number)
        {
            int sum = 0;

            foreach (char c in number)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    sum += digit;
                }
            }
            MessageBox.Show(sum.ToString());
        }
        public void um(string number)
        {
            int sum = 1;
            foreach(char c in number)
            {
                if(char.IsDigit(c))
                {
                    int digit = c - '0';
                    sum *= digit;
                }
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
