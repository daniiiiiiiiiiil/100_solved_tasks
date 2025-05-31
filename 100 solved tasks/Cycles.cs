using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    internal class Cycles
    {
        public int sumToN(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
                result+=i;
            return result;
        }
        public void findDivisors(int num)
        {
            List <int> result = new List<int>();
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    result.Add(i);
            }
            string message;
            if (result.Count == 0)
            {
                message = $"У числа {num} нет делителей кроме 1 и самого числа.";
            }
            else
            {
                message = string.Join(", ", result);
            }

            MessageBox.Show(message, "Делители числа");
        }
        public void countdown(int n)
        {
            while (n != 0)
            {
                MessageBox.Show(n.ToString());
                n--;
            }
            MessageBox.Show("Поехали");
        }
    }
}
