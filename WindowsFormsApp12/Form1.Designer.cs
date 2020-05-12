namespace WindowsFormsApp12
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
            this.Nn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nn
            // 
            this.Nn.Location = new System.Drawing.Point(203, 14);
            this.Nn.Name = "Nn";
            this.Nn.Size = new System.Drawing.Size(146, 22);
            this.Nn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер массива";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(15, 267);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(334, 55);
            this.rez.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mas
            // 
            this.mas.Location = new System.Drawing.Point(15, 55);
            this.mas.Multiline = true;
            this.mas.Name = "mas";
            this.mas.ReadOnly = true;
            this.mas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mas.Size = new System.Drawing.Size(486, 190);
            this.mas.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 362);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mas;
        private System.Windows.Forms.Button button2;
    }
}

