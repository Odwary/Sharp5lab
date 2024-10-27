namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainFiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFiletoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFiletoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveRenametoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TasktoolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAfterTasktoolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAfterTasktoolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFileContainTextBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FileReadOnlycheckBox1 = new System.Windows.Forms.CheckBox();
            this.MainFileNametextBox1 = new System.Windows.Forms.TextBox();
            this.WordToExcludeTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFiletoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainFiletoolStripMenuItem1
            // 
            this.MainFiletoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFiletoolStripMenuItem1,
            this.OpenFiletoolStripMenuItem2,
            this.SaveFiletoolStripMenuItem3,
            this.SaveRenametoolStripMenuItem4,
            this.TasktoolStripMenuItem5,
            this.SaveAfterTasktoolStripMenuItem6,
            this.ClearAfterTasktoolStripMenuItem7});
            this.MainFiletoolStripMenuItem1.Name = "MainFiletoolStripMenuItem1";
            this.MainFiletoolStripMenuItem1.Size = new System.Drawing.Size(48, 22);
            this.MainFiletoolStripMenuItem1.Text = "Файл";
            this.MainFiletoolStripMenuItem1.Click += new System.EventHandler(this.MainFiletoolStripMenuItem1_Click);
            // 
            // CreateFiletoolStripMenuItem1
            // 
            this.CreateFiletoolStripMenuItem1.Name = "CreateFiletoolStripMenuItem1";
            this.CreateFiletoolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.CreateFiletoolStripMenuItem1.Text = "Создать файл";
            this.CreateFiletoolStripMenuItem1.Click += new System.EventHandler(this.CreateFiletoolStripMenuItem1_Click);
            // 
            // OpenFiletoolStripMenuItem2
            // 
            this.OpenFiletoolStripMenuItem2.Name = "OpenFiletoolStripMenuItem2";
            this.OpenFiletoolStripMenuItem2.Size = new System.Drawing.Size(246, 22);
            this.OpenFiletoolStripMenuItem2.Text = "Открыть файл";
            this.OpenFiletoolStripMenuItem2.Click += new System.EventHandler(this.OpenFiletoolStripMenuItem2_Click);
            // 
            // SaveFiletoolStripMenuItem3
            // 
            this.SaveFiletoolStripMenuItem3.Name = "SaveFiletoolStripMenuItem3";
            this.SaveFiletoolStripMenuItem3.Size = new System.Drawing.Size(246, 22);
            this.SaveFiletoolStripMenuItem3.Text = "Сохранить файл";
            this.SaveFiletoolStripMenuItem3.Click += new System.EventHandler(this.SaveFiletoolStripMenuItem3_Click);
            // 
            // SaveRenametoolStripMenuItem4
            // 
            this.SaveRenametoolStripMenuItem4.Name = "SaveRenametoolStripMenuItem4";
            this.SaveRenametoolStripMenuItem4.Size = new System.Drawing.Size(246, 22);
            this.SaveRenametoolStripMenuItem4.Text = "Сохранить под другим именем";
            this.SaveRenametoolStripMenuItem4.Click += new System.EventHandler(this.SaveRenametoolStripMenuItem4_Click);
            // 
            // TasktoolStripMenuItem5
            // 
            this.TasktoolStripMenuItem5.Name = "TasktoolStripMenuItem5";
            this.TasktoolStripMenuItem5.Size = new System.Drawing.Size(246, 22);
            this.TasktoolStripMenuItem5.Text = "Решить задачу";
            this.TasktoolStripMenuItem5.Click += new System.EventHandler(this.TasktoolStripMenuItem5_Click);
            // 
            // SaveAfterTasktoolStripMenuItem6
            // 
            this.SaveAfterTasktoolStripMenuItem6.Name = "SaveAfterTasktoolStripMenuItem6";
            this.SaveAfterTasktoolStripMenuItem6.Size = new System.Drawing.Size(246, 22);
            this.SaveAfterTasktoolStripMenuItem6.Text = "Сохранить результат задачи";
            this.SaveAfterTasktoolStripMenuItem6.Click += new System.EventHandler(this.SaveAfterTasktoolStripMenuItem6_Click);
            // 
            // ClearAfterTasktoolStripMenuItem7
            // 
            this.ClearAfterTasktoolStripMenuItem7.Name = "ClearAfterTasktoolStripMenuItem7";
            this.ClearAfterTasktoolStripMenuItem7.Size = new System.Drawing.Size(246, 22);
            this.ClearAfterTasktoolStripMenuItem7.Text = "Очистить результат задачи";
            this.ClearAfterTasktoolStripMenuItem7.Click += new System.EventHandler(this.ClearAfterTasktoolStripMenuItem7_Click);
            // 
            // MainFileContainTextBox3
            // 
            this.MainFileContainTextBox3.Location = new System.Drawing.Point(8, 36);
            this.MainFileContainTextBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MainFileContainTextBox3.Multiline = true;
            this.MainFileContainTextBox3.Name = "MainFileContainTextBox3";
            this.MainFileContainTextBox3.ReadOnly = true;
            this.MainFileContainTextBox3.Size = new System.Drawing.Size(920, 74);
            this.MainFileContainTextBox3.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileReadOnlycheckBox1
            // 
            this.FileReadOnlycheckBox1.AutoSize = true;
            this.FileReadOnlycheckBox1.Location = new System.Drawing.Point(629, 6);
            this.FileReadOnlycheckBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FileReadOnlycheckBox1.Name = "FileReadOnlycheckBox1";
            this.FileReadOnlycheckBox1.Size = new System.Drawing.Size(145, 17);
            this.FileReadOnlycheckBox1.TabIndex = 4;
            this.FileReadOnlycheckBox1.Text = "Редактирование файла";
            this.FileReadOnlycheckBox1.UseVisualStyleBackColor = true;
            this.FileReadOnlycheckBox1.CheckedChanged += new System.EventHandler(this.FileReadOnlycheckBox1_CheckedChanged);
            // 
            // MainFileNametextBox1
            // 
            this.MainFileNametextBox1.Location = new System.Drawing.Point(64, 5);
            this.MainFileNametextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MainFileNametextBox1.Name = "MainFileNametextBox1";
            this.MainFileNametextBox1.ReadOnly = true;
            this.MainFileNametextBox1.Size = new System.Drawing.Size(545, 20);
            this.MainFileNametextBox1.TabIndex = 5;
            // 
            // WordToExcludeTextBox
            // 
            this.WordToExcludeTextBox.Location = new System.Drawing.Point(0, 169);
            this.WordToExcludeTextBox.Multiline = true;
            this.WordToExcludeTextBox.Name = "WordToExcludeTextBox";
            this.WordToExcludeTextBox.Size = new System.Drawing.Size(285, 56);
            this.WordToExcludeTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Введите слово-фильтр в окно ниже:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 526);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WordToExcludeTextBox);
            this.Controls.Add(this.MainFileNametextBox1);
            this.Controls.Add(this.FileReadOnlycheckBox1);
            this.Controls.Add(this.MainFileContainTextBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainFiletoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateFiletoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenFiletoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SaveFiletoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SaveRenametoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TasktoolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem SaveAfterTasktoolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ClearAfterTasktoolStripMenuItem7;
        private System.Windows.Forms.TextBox MainFileContainTextBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox FileReadOnlycheckBox1;
        private System.Windows.Forms.TextBox MainFileNametextBox1;
        private System.Windows.Forms.TextBox WordToExcludeTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

