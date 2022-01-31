
namespace _12_SQLcommands_WF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lName_textBox = new System.Windows.Forms.TextBox();
            this.fName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.search_butt = new System.Windows.Forms.Button();
            this.update_butt = new System.Windows.Forms.Button();
            this.delete_butt = new System.Windows.Forms.Button();
            this.insert_butt = new System.Windows.Forms.Button();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkBox_delete = new System.Windows.Forms.CheckBox();
            this.checkBox_update = new System.Windows.Forms.CheckBox();
            this.checkBox_insert = new System.Windows.Forms.CheckBox();
            this.checkBox_search = new System.Windows.Forms.CheckBox();
            this.showAll_butt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showAll_butt);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(367, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 296);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 199);
            this.listBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login";
            // 
            // lName_textBox
            // 
            this.lName_textBox.Enabled = false;
            this.lName_textBox.Location = new System.Drawing.Point(171, 228);
            this.lName_textBox.Name = "lName_textBox";
            this.lName_textBox.Size = new System.Drawing.Size(100, 20);
            this.lName_textBox.TabIndex = 20;
            // 
            // fName_textBox
            // 
            this.fName_textBox.Enabled = false;
            this.fName_textBox.Location = new System.Drawing.Point(171, 202);
            this.fName_textBox.Name = "fName_textBox";
            this.fName_textBox.Size = new System.Drawing.Size(100, 20);
            this.fName_textBox.TabIndex = 21;
            // 
            // password_textBox
            // 
            this.password_textBox.Enabled = false;
            this.password_textBox.Location = new System.Drawing.Point(171, 176);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 22;
            // 
            // login_textBox
            // 
            this.login_textBox.Enabled = false;
            this.login_textBox.Location = new System.Drawing.Point(171, 150);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(100, 20);
            this.login_textBox.TabIndex = 23;
            // 
            // search_butt
            // 
            this.search_butt.Enabled = false;
            this.search_butt.Location = new System.Drawing.Point(277, 276);
            this.search_butt.Name = "search_butt";
            this.search_butt.Size = new System.Drawing.Size(75, 23);
            this.search_butt.TabIndex = 16;
            this.search_butt.Text = "SEARCH";
            this.search_butt.UseVisualStyleBackColor = true;
            this.search_butt.Click += new System.EventHandler(this.search_butt_Click);
            // 
            // update_butt
            // 
            this.update_butt.Enabled = false;
            this.update_butt.Location = new System.Drawing.Point(196, 276);
            this.update_butt.Name = "update_butt";
            this.update_butt.Size = new System.Drawing.Size(75, 23);
            this.update_butt.TabIndex = 17;
            this.update_butt.Text = "UPDATE";
            this.update_butt.UseVisualStyleBackColor = true;
            this.update_butt.Click += new System.EventHandler(this.update_butt_Click);
            // 
            // delete_butt
            // 
            this.delete_butt.Enabled = false;
            this.delete_butt.Location = new System.Drawing.Point(115, 276);
            this.delete_butt.Name = "delete_butt";
            this.delete_butt.Size = new System.Drawing.Size(75, 23);
            this.delete_butt.TabIndex = 18;
            this.delete_butt.Text = "DELETE";
            this.delete_butt.UseVisualStyleBackColor = true;
            this.delete_butt.Click += new System.EventHandler(this.delete_butt_Click);
            // 
            // insert_butt
            // 
            this.insert_butt.Enabled = false;
            this.insert_butt.Location = new System.Drawing.Point(32, 276);
            this.insert_butt.Name = "insert_butt";
            this.insert_butt.Size = new System.Drawing.Size(75, 23);
            this.insert_butt.TabIndex = 28;
            this.insert_butt.Text = "INSERT";
            this.insert_butt.UseVisualStyleBackColor = true;
            this.insert_butt.Click += new System.EventHandler(this.insert_butt_Click);
            // 
            // id_textBox
            // 
            this.id_textBox.Enabled = false;
            this.id_textBox.Location = new System.Drawing.Point(171, 124);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(100, 20);
            this.id_textBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Id";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // checkBox_delete
            // 
            this.checkBox_delete.AutoSize = true;
            this.checkBox_delete.Location = new System.Drawing.Point(106, 70);
            this.checkBox_delete.Name = "checkBox_delete";
            this.checkBox_delete.Size = new System.Drawing.Size(57, 17);
            this.checkBox_delete.TabIndex = 31;
            this.checkBox_delete.Text = "Delete";
            this.checkBox_delete.UseVisualStyleBackColor = true;
            this.checkBox_delete.CheckedChanged += new System.EventHandler(this.checkBox_delete_CheckedChanged);
            // 
            // checkBox_update
            // 
            this.checkBox_update.AutoSize = true;
            this.checkBox_update.Location = new System.Drawing.Point(187, 69);
            this.checkBox_update.Name = "checkBox_update";
            this.checkBox_update.Size = new System.Drawing.Size(61, 17);
            this.checkBox_update.TabIndex = 31;
            this.checkBox_update.Text = "Update";
            this.checkBox_update.UseVisualStyleBackColor = true;
            this.checkBox_update.CheckedChanged += new System.EventHandler(this.checkBox_update_CheckedChanged);
            // 
            // checkBox_insert
            // 
            this.checkBox_insert.AutoSize = true;
            this.checkBox_insert.Location = new System.Drawing.Point(32, 69);
            this.checkBox_insert.Name = "checkBox_insert";
            this.checkBox_insert.Size = new System.Drawing.Size(52, 17);
            this.checkBox_insert.TabIndex = 31;
            this.checkBox_insert.Text = "Insert";
            this.checkBox_insert.UseVisualStyleBackColor = true;
            this.checkBox_insert.CheckedChanged += new System.EventHandler(this.checkBox_insert_CheckedChanged);
            // 
            // checkBox_search
            // 
            this.checkBox_search.AutoSize = true;
            this.checkBox_search.Location = new System.Drawing.Point(264, 68);
            this.checkBox_search.Name = "checkBox_search";
            this.checkBox_search.Size = new System.Drawing.Size(60, 17);
            this.checkBox_search.TabIndex = 32;
            this.checkBox_search.Text = "Search";
            this.checkBox_search.UseVisualStyleBackColor = true;
            this.checkBox_search.CheckedChanged += new System.EventHandler(this.checkBox_search_CheckedChanged);
            // 
            // showAll_butt
            // 
            this.showAll_butt.Location = new System.Drawing.Point(142, 236);
            this.showAll_butt.Name = "showAll_butt";
            this.showAll_butt.Size = new System.Drawing.Size(75, 23);
            this.showAll_butt.TabIndex = 1;
            this.showAll_butt.Text = "SHOW ALL";
            this.showAll_butt.UseVisualStyleBackColor = true;
            this.showAll_butt.Click += new System.EventHandler(this.showAll_butt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "1.  Выберите действие";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "2.  Заполните поля";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 320);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_search);
            this.Controls.Add(this.checkBox_insert);
            this.Controls.Add(this.checkBox_update);
            this.Controls.Add(this.checkBox_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.insert_butt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lName_textBox);
            this.Controls.Add(this.fName_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.search_butt);
            this.Controls.Add(this.update_butt);
            this.Controls.Add(this.delete_butt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "12_SQLcomands_WF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lName_textBox;
        private System.Windows.Forms.TextBox fName_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Button search_butt;
        private System.Windows.Forms.Button update_butt;
        private System.Windows.Forms.Button delete_butt;
        private System.Windows.Forms.Button insert_butt;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox checkBox_delete;
        private System.Windows.Forms.CheckBox checkBox_update;
        private System.Windows.Forms.CheckBox checkBox_insert;
        private System.Windows.Forms.CheckBox checkBox_search;
        private System.Windows.Forms.Button showAll_butt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

