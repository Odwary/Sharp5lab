using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Требования.
//1.Функциональность должна быть реализована в виде меню.
//2. Программа должна позволять:
//a.создавать новый файл;
//b.открывать существующий;
//c.сохранять его;
//d.сохранять под другим именем;
//e.обрабатывать открытый файл;
//f.сохранять результат обработки (в случае необходимости);
//g.очищать результат обработки.

//1..Дан текстовый файл, содержащий слова, разделенные одним или несколькими пробелами. Создать на его основе новый файл, состоящий
//только из тех строк первого файла, которые не содержат заданное слово.

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
