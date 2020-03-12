namespace _120320
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
            this.components = new System.ComponentModel.Container();
            this.FirstButton = new System.Windows.Forms.Button();
            this.ButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Operator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.ResultValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstButton.Location = new System.Drawing.Point(331, 12);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(98, 32);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "Кнопка";
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // ButtonTimer
            // 
            this.ButtonTimer.Tick += new System.EventHandler(this.OnButtonTimerTick);
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(58, 142);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(147, 20);
            this.Operand1.TabIndex = 1;
            this.Operand1.Text = "5";
            this.Operand1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(532, 142);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(147, 20);
            this.Operand2.TabIndex = 2;
            this.Operand2.Text = "7";
            // 
            // Operator
            // 
            this.Operator.Location = new System.Drawing.Point(310, 142);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(147, 20);
            this.Operator.TabIndex = 3;
            this.Operator.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оператор";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(344, 215);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.CalculateButton);
            // 
            // ResultValue
            // 
            this.ResultValue.AutoSize = true;
            this.ResultValue.Location = new System.Drawing.Point(363, 316);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.Size = new System.Drawing.Size(37, 13);
            this.ResultValue.TabIndex = 8;
            this.ResultValue.Text = "Result";
            this.ResultValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.FirstButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Timer ButtonTimer;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.TextBox Operator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label ResultValue;
    }
}

