using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string fileName = "";
        string projectPath = AppDomain.CurrentDomain.BaseDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainFiletoolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void CreateFiletoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string randomFileName = $"{Guid.NewGuid()}.txt";
            fileName = Path.Combine(projectPath, randomFileName);

            MainFileNametextBox1.Text = fileName;

            using (StreamWriter f_Out = new StreamWriter(fileName))
            {
                f_Out.Write("");
            }
        }


        private void OpenFiletoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                MainFileNametextBox1.Text = fileName;
                using (StreamReader f_In = new StreamReader(fileName))
                    MainFileContainTextBox3.Text = f_In.ReadToEnd();
            }
        }
        private void SaveFiletoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (fileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                    MainFileNametextBox1.Text = fileName;
                }
            }
            else
            {
                using (StreamWriter f_Out = new StreamWriter(fileName))
                {
                    f_Out.WriteLine(MainFileContainTextBox3.Text);
                }
            }
        }

        private void SaveRenametoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                MainFileNametextBox1.Text = fileName;
                using (StreamWriter f_Out = new StreamWriter(saveFileDialog1.FileName))
                    f_Out.WriteLine(MainFileContainTextBox3.Text);
            }
        }

        private void TasktoolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дан текстовый файл, содержащий слова, разделенные одним или несколькими пробелами. " +
                "Создать на его основе новый файл, состоящий только из тех строк первого файла, \r\nкоторые не содержат заданное слово.");
            string wordToExclude = WordToExcludeTextBox.Text; // Заданное слово для исключения

            string[] lines = MainFileContainTextBox3.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            using (StreamWriter f_Out = new StreamWriter(Path.Combine(projectPath, "FilteredFile.txt")))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains(wordToExclude))
                    {
                        f_Out.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Файл был создан, строки с заданным словом исключены.");
        }


        private void SaveAfterTasktoolStripMenuItem6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string newFileName = saveFileDialog1.FileName;

                using (StreamReader f_In = new StreamReader(Path.Combine(projectPath, "FilteredFile.txt")))
                using (StreamWriter f_Out = new StreamWriter(newFileName))
                {
                    string content = f_In.ReadToEnd();
                    f_Out.Write(content);
                }

                MessageBox.Show("Результат сохранен в новый файл.");
            }
        }


        private void ClearAfterTasktoolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string filteredFilePath = Path.Combine(projectPath, "FilteredFile.txt");

            // Удаление файла с отфильтрованными данными, если он существует
            if (File.Exists(filteredFilePath))
            {
                File.Delete(filteredFilePath);
            }

            // Очистка текстовых полей на форме
            MainFileContainTextBox3.Text = "";
            WordToExcludeTextBox.Text = "";

            MessageBox.Show("Файл с результатами фильтрации был удален, поля очищены.");
        }


        private void FileReadOnlycheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FileReadOnlycheckBox1.Checked)
                MainFileContainTextBox3.ReadOnly = false;
            else
                MainFileContainTextBox3.ReadOnly = true;
        }
    }
}
