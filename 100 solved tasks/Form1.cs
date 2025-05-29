using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    public partial class Form1 : Form
    {
        if_else_switch taskOp;
        Cycles cycles;
        public Form1()
        {
            InitializeComponent();
            taskOp = new if_else_switch();
            cycles = new Cycles();
        }

        private void conditions1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию isEven(num), которая возвращает true, если число чётное, и false — если нечётное.");
        }
        
        private void code1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public string isEven(int num)\r\n        {\r\n            string result;\r\n            if (num % 2 == 0)\r\n            {\r\n                result = \"Четное\";\r\n                MessageBox.Show(result);\r\n            }\r\n            else\r\n            {\r\n                result = \"Нечетное\";\r\n                MessageBox.Show(result);\r\n            }\r\n            return result;\r\n        }");
        }

        private void result1_Click(object sender, EventArgs e)
        {
            taskOp.isEven(5);
        }

        private void conditions2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию getTimeOfDay(hour), которая принимает час (0-23) и возвращает:\r\n\r\n\"Утро\" (6-11)\r\n\r\n\"День\" (12-17)\r\n\r\n\"Вечер\" (18-23)\r\n\r\n\"Ночь\" (0-5)");
        }

        private void code2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public string getTimeOfDay(int hour)\r\n        {\r\n            string result = \"\";\r\n            if (hour >= 6 && hour <= 11)\r\n                result = \"Утро\";\r\n            else if (hour >= 12 && hour <= 17)\r\n                result = \"День\";\r\n            else if (hour >= 18 && hour <= 23)\r\n                result = \"Вечер\";\r\n            else if (hour >= 0 && hour <= 5) \r\n                result = \"Ночь\";\r\n            return result;\r\n        }");
        }

        private void result2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(taskOp.getTimeOfDay(5));
        }

        private void conditions3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию calculate(a, b, operation), которая принимает два числа и строку (+, -, *, /), а затем возвращает результат операции. Используйте switch.");
        }

        private void code3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public int calculate(int a,int b,char operation)\r\n        {\r\n            int result = 0;\r\n            switch (operation) \r\n            {\r\n                case '+':\r\n                    result = a + b;\r\n                    break;\r\n                case '-':\r\n                    result = a - b;\r\n                    break;\r\n                case '*':\r\n                    result = a * b;\r\n                    break;\r\n                case '/':\r\n                    result = a / b;\r\n                    break;\r\n            }\r\n            return result;\r\n        }");
        }

        private void result3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(taskOp.calculate(3, 5, '-').ToString());
        }

        private void conditions4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию sumToN(n), которая возвращает сумму всех чисел от 1 до n (включительно).");
        }

        private void code4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public int sumToN(int n)\r\n        {\r\n            int result = 0;\r\n            for (int i = 0; i <= n; i++)\r\n                result+=i;\r\n            return result;\r\n        }");
        }

        private void result4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cycles.sumToN(5).ToString());
        }

        private void conditions5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию findDivisors(num), которая выводит все делители числа (кроме 1 и самого числа).");
        }

        private void code5_Click(object sender, EventArgs e)
        {

        }

        private void result5_Click(object sender, EventArgs e)
        {
            cycles.findDivisors(12);
        }
    }
}
