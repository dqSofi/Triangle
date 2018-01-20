namespace Triangle
{
    partial class Triangle
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(38, 11);
            this.textBoxA.MaxLength = 10;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(118, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(38, 37);
            this.textBoxB.MaxLength = 10;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(118, 20);
            this.textBoxB.TabIndex = 2;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(38, 64);
            this.textBoxC.MaxLength = 10;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(118, 20);
            this.textBoxC.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(162, 60);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(284, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Определить";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.resultClick);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(162, 11);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(284, 20);
            this.textBoxRes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "А =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C =";
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 96);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Triangle";
            this.Text = "Определение типа треугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

