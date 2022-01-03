
namespace _05_Calculator_WinForms
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CalculatorDisplay = new System.Windows.Forms.Label();
            this.button_egual = new System.Windows.Forms.Button();
            this.button_dev = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CalculatorDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.button_egual);
            this.splitContainer1.Panel2.Controls.Add(this.button_dev);
            this.splitContainer1.Panel2.Controls.Add(this.button_mult);
            this.splitContainer1.Panel2.Controls.Add(this.button_minus);
            this.splitContainer1.Panel2.Controls.Add(this.button_plus);
            this.splitContainer1.Panel2.Controls.Add(this.button_comma);
            this.splitContainer1.Panel2.Controls.Add(this.buttonC);
            this.splitContainer1.Panel2.Controls.Add(this.button0);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(315, 322);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // CalculatorDisplay
            // 
            this.CalculatorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatorDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatorDisplay.Location = new System.Drawing.Point(0, 0);
            this.CalculatorDisplay.Name = "CalculatorDisplay";
            this.CalculatorDisplay.Size = new System.Drawing.Size(315, 75);
            this.CalculatorDisplay.TabIndex = 0;
            this.CalculatorDisplay.Text = "0";
            this.CalculatorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_egual
            // 
            this.button_egual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_egual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_egual.Location = new System.Drawing.Point(248, 126);
            this.button_egual.Name = "button_egual";
            this.button_egual.Size = new System.Drawing.Size(53, 102);
            this.button_egual.TabIndex = 16;
            this.button_egual.Tag = "b_equal";
            this.button_egual.Text = "=";
            this.button_egual.UseVisualStyleBackColor = true;
            this.button_egual.Click += new System.EventHandler(this.button_egual_Click);
            // 
            // button_dev
            // 
            this.button_dev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dev.Location = new System.Drawing.Point(130, 182);
            this.button_dev.Name = "button_dev";
            this.button_dev.Size = new System.Drawing.Size(112, 47);
            this.button_dev.TabIndex = 15;
            this.button_dev.Tag = "b_dev";
            this.button_dev.Text = "/";
            this.button_dev.UseVisualStyleBackColor = true;
            this.button_dev.Click += new System.EventHandler(this.button_dev_Click);
            // 
            // button_mult
            // 
            this.button_mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mult.Location = new System.Drawing.Point(189, 126);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(53, 47);
            this.button_mult.TabIndex = 14;
            this.button_mult.Tag = "b_mult";
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_minus
            // 
            this.button_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(189, 73);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(53, 47);
            this.button_minus.TabIndex = 13;
            this.button_minus.Tag = "b_minus";
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(189, 20);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(53, 47);
            this.button_plus.TabIndex = 12;
            this.button_plus.Tag = "b_plus";
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_comma
            // 
            this.button_comma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_comma.Location = new System.Drawing.Point(12, 182);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(53, 47);
            this.button_comma.TabIndex = 11;
            this.button_comma.Tag = "b_comma";
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // buttonC
            // 
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(248, 20);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(53, 100);
            this.buttonC.TabIndex = 10;
            this.buttonC.Tag = "b_C";
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button0
            // 
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(71, 182);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 47);
            this.button0.TabIndex = 9;
            this.button0.Tag = "b_0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(130, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 47);
            this.button9.TabIndex = 8;
            this.button9.Tag = "b_9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(71, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 47);
            this.button8.TabIndex = 7;
            this.button8.Tag = "b_8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 47);
            this.button7.TabIndex = 6;
            this.button7.Tag = "b_7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(130, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 47);
            this.button6.TabIndex = 5;
            this.button6.Tag = "b_6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(71, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 47);
            this.button5.TabIndex = 4;
            this.button5.Tag = "b_5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 47);
            this.button4.TabIndex = 3;
            this.button4.Tag = "b_4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(130, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 47);
            this.button3.TabIndex = 2;
            this.button3.Tag = "b_3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(71, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 47);
            this.button2.TabIndex = 1;
            this.button2.Tag = "b_2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 47);
            this.button1.TabIndex = 0;
            this.button1.Tag = "b_1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 322);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CalculatorDisplay;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_egual;
        private System.Windows.Forms.Button button_dev;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
    }
}

