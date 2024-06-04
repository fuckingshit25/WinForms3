using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace WinForms_Тема3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Указываем путь к файлу с числами
        string inputFilePath = "input.txt"; //Файл находится в ...\ConsoleNumberConverter\bin\Debug\netcoreapp3.1\input.txt
        string outputFilePath = "output.txt";
        List<int> numbers = new List<int>();
        private void button_Click(object sender, EventArgs e)
        {
            
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(inputFilePath);
            
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        NumbersFromFile.Text += number + "; ";
                        numbers.Add(number);
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение: " + line);
                    }
                }
            }
        }
        private void ConverterButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (int number in numbers)
                {
                    // Переводим число в пятеричную систему и записываем результат в файл
                    string baseFive = NumberConverter.ToBaseFive(number);
                    writer.WriteLine(baseFive);
                    ConverterNumbers.Text+=baseFive+"; ";
                }
            }
            MessageBox.Show("Перевод выполнен! Результат записан в файл output.txt");
        }
    }
}
