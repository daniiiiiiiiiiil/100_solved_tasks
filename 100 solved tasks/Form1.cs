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
        Functions functions;
        Array array;
        public Form1()
        {
            InitializeComponent();
            taskOp = new if_else_switch();
            cycles = new Cycles();
            functions = new Functions();
            array = new Array();
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
            MessageBox.Show("public void findDivisors(int num)\r\n        {\r\n            List <int> result = new List<int>();\r\n            for (int i = 2; i <= num / 2; i++)\r\n            {\r\n                if (num % i == 0)\r\n                    result.Add(i);\r\n            }\r\n            string message;\r\n            if (result.Count == 0)\r\n            {\r\n                message = $\"У числа {num} нет делителей кроме 1 и самого числа.\";\r\n            }\r\n            else\r\n            {\r\n                message = string.Join(\", \", result);\r\n            }\r\n\r\n            MessageBox.Show(message, \"Делители числа\");\r\n        }");
        }

        private void result5_Click(object sender, EventArgs e)
        {
            cycles.findDivisors(12);
        }

        private void conditions6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию countdown(n), которая выводит числа от n до 1, а затем \"Поехали!\". Используйте while.");
        }

        private void code6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void countdown(int n)\r\n        {\r\n            while (n != 0)\r\n            {\r\n                MessageBox.Show(n.ToString());\r\n                n--;\r\n            }\r\n            MessageBox.Show(\"Поехали\");\r\n        }");
        }

        private void result6_Click(object sender, EventArgs e)
        {
            cycles.countdown(5);
        }

        private void conditions7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напишите функцию max(a, b), которая возвращает наибольшее из двух чисел.");
        }

        private void code7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public void max(int a,int b)\r\n        {\r\n            if (a > b)\r\n                MessageBox.Show(a.ToString());\r\n            else MessageBox.Show(b.ToString());\r\n        }");
        }

        private void result7_Click(object sender, EventArgs e)
        {
            functions.max(5, 10);
        }

        private void conditions8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вернуть массив только чётных чисел из исходного.\r\nПример: [1, 2, 3, 4] → [2, 4]");
        }

        private void code8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public void even_numbers()\r\n        {\r\n            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };\r\n            for (int i = 0; i < array.Length; i++)\r\n            {\r\n                if (array[i] % 2 == 0)\r\n                {\r\n                    MessageBox.Show(array[i].ToString());\r\n                }\r\n            }\r\n        }");
        }

        private void result8_Click(object sender, EventArgs e)
        {
            array.even_numbers();
        }

        private void conditions9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подсчёт гласных в строке\r\nПосчитать количество гласных (а, е, и, о, у, ы, э, ю, я).\r\nПример: \"Привет\" → 2");
        }


        private void code9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void number_of_vowels(string word)\r\n        {\r\n            int count = 0;\r\n            char[] arr= { 'а', 'е', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };\r\n            for (int i = 0; i < word.Length; i++)\r\n            {\r\n                for (int j = 0; j < arr.Length; j++)\r\n                {\r\n                    if (word[i] == arr[j])\r\n                        count++;\r\n                }\r\n            }\r\n            MessageBox.Show(count.ToString());\r\n        }");
        }

        private void result9_Click(object sender, EventArgs e)
        {
            array.number_of_vowels("Привет");
        }

        private void conditions10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка палиндрома\r\nОпределить, является ли строка палиндромом.\r\nПример: \"топот\" → true");
        }

        private void code10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void palindromes(string word)\r\n        {\r\n            bool s = true;\r\n            string revers = new string(word.Reverse().ToArray());\r\n            if(word == revers)\r\n                s = true;\r\n            else \r\n                s = false;\r\n            MessageBox.Show(s.ToString());\r\n        }");
        }

        private void result10_Click(object sender, EventArgs e)
        {
            array.palindromes("топот");
        }

        private void conditions11_Click(object sender, EventArgs e)
        {

        }

        private void code11_Click(object sender, EventArgs e)
        {

        }

        private void result11_Click(object sender, EventArgs e)
        {
            array.order("Hello World");
        }
    }
}
