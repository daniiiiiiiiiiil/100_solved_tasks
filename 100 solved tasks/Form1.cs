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
        Task task;
        public Form1()
        {
            InitializeComponent();
            taskOp = new if_else_switch();
            cycles = new Cycles();
            functions = new Functions();
            array = new Array();
            task = new Task();
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
            MessageBox.Show("Дана строка слов. Вернуть их в обратном порядке.\r\nПример: \"Hello World\" → \"World Hello\"");
        }

        private void code11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void Reverse_word_order(string word)\r\n        {\r\n            List<string> words = new List<string>(word.Split(' '));\r\n            words.Reverse();\r\n            string reversed = string.Join(\" \", words);\r\n            MessageBox.Show(reversed.ToString());\r\n        }");
        }

        private void result11_Click(object sender, EventArgs e)
        {
            array.Reverse_word_order("Hello Wordl");
        }

        private void conditions12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поиск минимального числа в массиве\r\nНайти наименьшее число в массиве.\r\nПример: [5, 2, 9, 1] → 1");
        }

        private void code12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public void min()\r\n        {\r\n            int[] numbers = { 5, 2, 9, 1 };\r\n\r\n            int min = numbers[0]; \r\n\r\n            for (int i = 1; i < numbers.Length; i++)\r\n            {\r\n                if (numbers[i] < min)\r\n                {\r\n                    min = numbers[i];\r\n                }\r\n            }\r\n            MessageBox.Show(min.ToString());\r\n        }");
        }

        private void result12_Click(object sender, EventArgs e)
        {
            array.min();
        }

        private void conditions13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление дубликатов из массива\r\nВернуть массив без повторяющихся элементов.\r\nПример: [1, 2, 2, 3] → [1, 2, 3]");
        }

        private void code13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void Delete()\r\n        {\r\n            List<int> numbers = new List<int> { 1, 2, 3, 2, 4,3, 2, 5 };\r\n            List<int> uniqueNumbers = numbers.Distinct().ToList();\r\n            MessageBox.Show(string.Join(\", \", uniqueNumbers));\r\n        }");
        }

        private void result13_Click(object sender, EventArgs e)
        {
            array.Delete();
        }

        private void conditions14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подсчёт суммы цифр числа\r\nНайти сумму цифр числа.\r\nПример: 123 → 6");
        }

        private void Code14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void sum(string number)\r\n        {\r\n            int sum = 0;\r\n\r\n            foreach (char c in number)\r\n            {\r\n                if (char.IsDigit(c))\r\n                {\r\n                    int digit = c - '0';\r\n                    sum += digit;\r\n                }\r\n            }\r\n            MessageBox.Show(sum.ToString());\r\n        }\r\n        public void um(string number)\r\n        {\r\n            int sum = 1;\r\n            foreach(char c in number)\r\n            {\r\n                if(char.IsDigit(c))\r\n                {\r\n                    int digit = c - '0';\r\n                    sum *= digit;\r\n                }\r\n            }\r\n            MessageBox.Show(sum.ToString());\r\n        }");
        }

        private void result14_Click(object sender, EventArgs e)
        {
            array.sum("123");
            array.um("789");
        }

        private void conditions15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка на простое число\r\nОпределить, является ли число простым.\r\nПример: 7 → true");
        }

        private void Code15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public bool simple(int number)\r\n        {\r\n            if(number < 2)\r\n                return false;\r\n            int limit = (int) Math.Sqrt(number);\r\n            for(int i = 2;i<=limit;i++)\r\n            {\r\n                if(number % i ==0) return true;\r\n            }\r\n            return true;\r\n        }");
        }

        private void result15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(task.simple(7).ToString());
        }

        private void conditions16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подсчёт слов в строке\r\nВернуть количество слов в строке.\r\nПример: \"Hello world\" → 2");
        }

        private void Code16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public int CountingWords(string line)\r\n        {\r\n            string[] words = line.Split(new char[] { ' ', '\\t', '\\n', '\\r' }, StringSplitOptions.RemoveEmptyEntries);\r\n            return words.Length;\r\n        }");
        }

        private void result16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(task.CountingWords("Hello world").ToString());
        }

        private void conditions17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Замена пробелов на дефисы\r\nЗаменить все пробелы в строке на -.\r\nПример: \"Hello world\" → \"Hello-world\"");
        }

        private void Code17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public string Spaces(string line)\r\n        {\r\n            string replace = line.Replace(' ','-');\r\n            return replace;\r\n        }");
        }

        private void result17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(task.Spaces("Hello wordl"));
        }

        private void conditions18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сумма элементов массива\r\nНайти сумму всех чисел в массиве.\r\nПример: [1, 2, 3] → 6");
        }

        private void Code18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void SumArr()\r\n        {\r\n            int sum = 0;\r\n            int[] arr = { 1, 2, 3 };\r\n            for (int i = 0; i < arr.Length; i++)\r\n            {\r\n                sum += arr[i];\r\n            }\r\n            MessageBox.Show(sum.ToString());\r\n        }");
        }

        private void result18_Click(object sender, EventArgs e)
        {
            array.SumArr();
        }

        private void conditions19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поиск индекса элемента\r\nВернуть индекс первого вхождения элемента в массиве.\r\nПример: [1, 2, 3], 2 → 1");
        }

        private void Code19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("public void Index(int num)\r\n        {\r\n            List<int> numbers = new List<int> { 1,2,3 };\r\n            int index = numbers.IndexOf(num);\r\n            MessageBox.Show(index.ToString());\r\n        }");
        }

        private void result19_Click(object sender, EventArgs e)
        {
            array.Index(2);
        }

        private void conditions20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объединение двух массивов\r\nСоздать новый массив из двух данных.\r\nПример: [1, 2], [3, 4] → [1, 2, 3, 4]");
        }

        private void Code20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" public void Unification()\r\n        {\r\n            int[] arr = { 1, 2 };\r\n            int[] arr1 = { 3, 4 };\r\n            int[] arr2 = new int[arr.Length + arr1.Length];\r\n            arr.CopyTo(arr2, 0);\r\n            arr1.CopyTo(arr2, arr1.Length);\r\n\r\n            MessageBox.Show(string.Join(\", \", arr2));\r\n        }");
        }

        private void result20_Click(object sender, EventArgs e)
        {
            array.Unification();
        }

        private void conditions21_Click(object sender, EventArgs e)
        {

        }

        private void code21_Click(object sender, EventArgs e)
        {

        }

        private void result21_Click(object sender, EventArgs e)
        {
            task.Counting_Letters("helllo");
        }
    }
}
