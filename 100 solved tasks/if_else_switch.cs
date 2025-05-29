using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    internal class if_else_switch
    {
        public string isEven(int num)
        {
            string result;
            if (num % 2 == 0)
            {
                result = "Четное";
                MessageBox.Show(result);
            }
            else
            {
                result = "Нечетное";
                MessageBox.Show(result);
            }
            return result;
        }
        public string getTimeOfDay(int hour)
        {
            string result = "";
            if (hour >= 6 && hour <= 11)
                result = "Утро";
            else if (hour >= 12 && hour <= 17)
                result = "День";
            else if (hour >= 18 && hour <= 23)
                result = "Вечер";
            else if (hour >= 0 && hour <= 5) 
                result = "Ночь";
            return result;
        }
        public int calculate(int a,int b,char operation)
        {
            int result = 0;
            switch (operation) 
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}
