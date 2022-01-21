
namespace _10_Login_WinF_SQL
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
            this.login_field = new System.Windows.Forms.TextBox();
            this.pass_field = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(91, 45);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(100, 20);
            this.login_field.TabIndex = 0;
            // 
            // pass_field
            // 
            this.pass_field.Location = new System.Drawing.Point(91, 96);
            this.pass_field.Name = "pass_field";
            this.pass_field.Size = new System.Drawing.Size(100, 20);
            this.pass_field.TabIndex = 0;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(12, 46);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(40, 13);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "LOGIN";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(12, 97);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 13);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "PASSWORD";
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(79, 177);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 23);
            this.enter_button.TabIndex = 3;
            this.enter_button.Text = "ВОЙТИ";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 238);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.pass_field);
            this.Controls.Add(this.login_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.TextBox pass_field;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button enter_button;
    }
}

