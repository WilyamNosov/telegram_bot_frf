namespace db_add_schedule
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shchedule = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classroom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.back1 = new System.Windows.Forms.TabPage();
            this.backList1 = new System.Windows.Forms.CheckedListBox();
            this.back2 = new System.Windows.Forms.TabPage();
            this.backList2 = new System.Windows.Forms.CheckedListBox();
            this.back3 = new System.Windows.Forms.TabPage();
            this.backList3 = new System.Windows.Forms.CheckedListBox();
            this.back4 = new System.Windows.Forms.TabPage();
            this.backList4 = new System.Windows.Forms.CheckedListBox();
            this.mag1 = new System.Windows.Forms.TabPage();
            this.magisterList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lectionNum = new System.Windows.Forms.ComboBox();
            this.lecturers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.discipline = new System.Windows.Forms.TextBox();
            this.addToShchedule = new System.Windows.Forms.Button();
            this.shcheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip2.SuspendLayout();
            this.shchedule.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.back1.SuspendLayout();
            this.back2.SuspendLayout();
            this.back3.SuspendLayout();
            this.back4.SuspendLayout();
            this.mag1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(888, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // shchedule
            // 
            this.shchedule.Controls.Add(this.tabPage2);
            this.shchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shchedule.Location = new System.Drawing.Point(0, 24);
            this.shchedule.Name = "shchedule";
            this.shchedule.SelectedIndex = 0;
            this.shchedule.Size = new System.Drawing.Size(888, 375);
            this.shchedule.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розклад";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.classroom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lectionNum);
            this.panel1.Controls.Add(this.lecturers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.discipline);
            this.panel1.Controls.Add(this.addToShchedule);
            this.panel1.Controls.Add(this.shcheduleCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // classroom
            // 
            this.classroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classroom.Location = new System.Drawing.Point(389, 92);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(121, 22);
            this.classroom.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Аудиторія";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.back1);
            this.tabControl2.Controls.Add(this.back2);
            this.tabControl2.Controls.Add(this.back3);
            this.tabControl2.Controls.Add(this.back4);
            this.tabControl2.Controls.Add(this.mag1);
            this.tabControl2.Location = new System.Drawing.Point(8, 92);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(268, 144);
            this.tabControl2.TabIndex = 29;
            // 
            // back1
            // 
            this.back1.Controls.Add(this.backList1);
            this.back1.Location = new System.Drawing.Point(4, 25);
            this.back1.Name = "back1";
            this.back1.Padding = new System.Windows.Forms.Padding(3);
            this.back1.Size = new System.Drawing.Size(260, 115);
            this.back1.TabIndex = 0;
            this.back1.Text = "1 курс";
            this.back1.UseVisualStyleBackColor = true;
            // 
            // backList1
            // 
            this.backList1.FormattingEnabled = true;
            this.backList1.Items.AddRange(new object[] {
            "1КНІТ-А",
            "1КНІТ-Б",
            "1КНІТ-В",
            "1БІКС",
            "1СОФ"});
            this.backList1.Location = new System.Drawing.Point(3, 3);
            this.backList1.Name = "backList1";
            this.backList1.Size = new System.Drawing.Size(134, 106);
            this.backList1.TabIndex = 0;
            // 
            // back2
            // 
            this.back2.Controls.Add(this.backList2);
            this.back2.Location = new System.Drawing.Point(4, 25);
            this.back2.Name = "back2";
            this.back2.Padding = new System.Windows.Forms.Padding(3);
            this.back2.Size = new System.Drawing.Size(260, 115);
            this.back2.TabIndex = 1;
            this.back2.Text = "2 курс";
            this.back2.UseVisualStyleBackColor = true;
            // 
            // backList2
            // 
            this.backList2.FormattingEnabled = true;
            this.backList2.Items.AddRange(new object[] {
            "2КНІТ-А",
            "2КНІТ-Б",
            "2КНІТ-В",
            "2БІКС",
            "2СОФ"});
            this.backList2.Location = new System.Drawing.Point(3, 3);
            this.backList2.Name = "backList2";
            this.backList2.Size = new System.Drawing.Size(134, 106);
            this.backList2.TabIndex = 1;
            // 
            // back3
            // 
            this.back3.Controls.Add(this.backList3);
            this.back3.Location = new System.Drawing.Point(4, 25);
            this.back3.Name = "back3";
            this.back3.Size = new System.Drawing.Size(260, 115);
            this.back3.TabIndex = 2;
            this.back3.Text = "3 курс";
            this.back3.UseVisualStyleBackColor = true;
            // 
            // backList3
            // 
            this.backList3.FormattingEnabled = true;
            this.backList3.Items.AddRange(new object[] {
            "3КН-А",
            "3КН-Б1",
            "3КН-Б2",
            "3КН-В1",
            "3КН-В2",
            "3БІКС",
            "МтІВТ"});
            this.backList3.Location = new System.Drawing.Point(3, 3);
            this.backList3.Name = "backList3";
            this.backList3.Size = new System.Drawing.Size(134, 106);
            this.backList3.TabIndex = 2;
            this.backList3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // back4
            // 
            this.back4.Controls.Add(this.backList4);
            this.back4.Location = new System.Drawing.Point(4, 25);
            this.back4.Name = "back4";
            this.back4.Size = new System.Drawing.Size(260, 115);
            this.back4.TabIndex = 3;
            this.back4.Text = "4 курс";
            this.back4.UseVisualStyleBackColor = true;
            // 
            // backList4
            // 
            this.backList4.BackColor = System.Drawing.SystemColors.Window;
            this.backList4.FormattingEnabled = true;
            this.backList4.Items.AddRange(new object[] {
            "4КНІТ-А",
            "4КНІТ-Б",
            "4КНІТ-В",
            "4БІКС"});
            this.backList4.Location = new System.Drawing.Point(3, 3);
            this.backList4.Name = "backList4";
            this.backList4.Size = new System.Drawing.Size(134, 106);
            this.backList4.TabIndex = 2;
            // 
            // mag1
            // 
            this.mag1.Controls.Add(this.magisterList);
            this.mag1.Location = new System.Drawing.Point(4, 25);
            this.mag1.Name = "mag1";
            this.mag1.Size = new System.Drawing.Size(260, 115);
            this.mag1.TabIndex = 4;
            this.mag1.Text = "5 курс";
            this.mag1.UseVisualStyleBackColor = true;
            // 
            // magisterList
            // 
            this.magisterList.FormattingEnabled = true;
            this.magisterList.Items.AddRange(new object[] {
            "2КНІТ-А",
            "2КНІТ-Б",
            "2КНІТ-В",
            "2БІКС",
            "2СОФ"});
            this.magisterList.Location = new System.Drawing.Point(3, 3);
            this.magisterList.Name = "magisterList";
            this.magisterList.Size = new System.Drawing.Size(134, 106);
            this.magisterList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "№ Пари";
            // 
            // lectionNum
            // 
            this.lectionNum.FormattingEnabled = true;
            this.lectionNum.Items.AddRange(new object[] {
            "1 Пара",
            "2 Пара",
            "3 Пара",
            "4 Пара",
            "5 Пара",
            "6 Пара",
            "7 Пара",
            "8 Пара"});
            this.lectionNum.Location = new System.Drawing.Point(389, 31);
            this.lectionNum.Name = "lectionNum";
            this.lectionNum.Size = new System.Drawing.Size(121, 24);
            this.lectionNum.TabIndex = 27;
            // 
            // lecturers
            // 
            this.lecturers.FormattingEnabled = true;
            this.lecturers.ItemHeight = 16;
            this.lecturers.Items.AddRange(new object[] {
            "Парамонов Антон Іванович",
            "Ніколюк Петро Карпович",
            "Каргін Анатолій Олексійович",
            "Петренко Тетяна Григорівна",
            "Тимчук Олег Сергійович",
            "Єпік Марина Олександрівна",
            "Крачковський Микола Володимирович",
            "Махно Таісія Олександрівна",
            "Сапунов Сергій Валерійович",
            "Гаркуша Віктор Володимирович",
            "Кадомський Кирило Костянтинович",
            "Українець Ірина Володимирівна",
            "Мацецька Наталія Артурівна",
            "Галич Георгій Борисович",
            "Богуто Денис Геннадійович",
            "Барибін Олексій Ігорович",
            "Крижановський Володимир Григорович",
            "Сергієнко Сергій Петрович",
            "Фурса Світлана Євгенівна",
            "Загоруйко Любов Василівна",
            "Чернов Дмитро Вікторович",
            "Дудатьєв Андрій Веніамінович",
            "Бондаренко Ганна Михайлівна",
            "Русаков Володимир Федорович",
            "Зубов Едуард Євгенович",
            "Зюбанов Олександр Євгенович",
            "Ткаченко Віра Сергіївна",
            "Пицюга Володимир Григорович",
            "Русакова Надія Михайлівна",
            "Демченко Катерина В’ячеславівна"});
            this.lecturers.Location = new System.Drawing.Point(584, 31);
            this.lecturers.Name = "lecturers";
            this.lecturers.Size = new System.Drawing.Size(285, 292);
            this.lecturers.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Викладачі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Група";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дисципліна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // discipline
            // 
            this.discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discipline.Location = new System.Drawing.Point(8, 31);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(364, 22);
            this.discipline.TabIndex = 2;
            // 
            // addToShchedule
            // 
            this.addToShchedule.Location = new System.Drawing.Point(15, 295);
            this.addToShchedule.Name = "addToShchedule";
            this.addToShchedule.Size = new System.Drawing.Size(132, 28);
            this.addToShchedule.TabIndex = 1;
            this.addToShchedule.Text = "Додати";
            this.addToShchedule.UseVisualStyleBackColor = true;
            this.addToShchedule.Click += new System.EventHandler(this.addToShchedule_Click);
            // 
            // shcheduleCalendar
            // 
            this.shcheduleCalendar.Location = new System.Drawing.Point(389, 161);
            this.shcheduleCalendar.Name = "shcheduleCalendar";
            this.shcheduleCalendar.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(888, 399);
            this.Controls.Add(this.shchedule);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Shchedule";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.shchedule.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.back1.ResumeLayout(false);
            this.back2.ResumeLayout(false);
            this.back3.ResumeLayout(false);
            this.back4.ResumeLayout(false);
            this.mag1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl shchedule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discipline;
        private System.Windows.Forms.Button addToShchedule;
        private System.Windows.Forms.MonthCalendar shcheduleCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lecturers;
        private System.Windows.Forms.ComboBox lectionNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage back1;
        private System.Windows.Forms.CheckedListBox backList1;
        private System.Windows.Forms.TabPage back2;
        private System.Windows.Forms.CheckedListBox backList2;
        private System.Windows.Forms.TabPage back3;
        private System.Windows.Forms.CheckedListBox backList3;
        private System.Windows.Forms.TabPage back4;
        private System.Windows.Forms.CheckedListBox backList4;
        private System.Windows.Forms.TabPage mag1;
        private System.Windows.Forms.CheckedListBox magisterList;
        private System.Windows.Forms.TextBox classroom;
        private System.Windows.Forms.Label label5;
    }
}

