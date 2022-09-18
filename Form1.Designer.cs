namespace PrimeNumberWithForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_button1 = new System.Windows.Forms.Button();
            this.input_textBox1 = new System.Windows.Forms.TextBox();
            this.answer_label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_button1
            // 
            this.check_button1.Location = new System.Drawing.Point(12, 58);
            this.check_button1.Name = "check_button1";
            this.check_button1.Size = new System.Drawing.Size(289, 29);
            this.check_button1.TabIndex = 0;
            this.check_button1.Text = "Тест Миллера Раббина";
            this.check_button1.UseVisualStyleBackColor = true;
            this.check_button1.Click += new System.EventHandler(this.check_button1_Click);
            // 
            // input_textBox1
            // 
            this.input_textBox1.Location = new System.Drawing.Point(12, 12);
            this.input_textBox1.Name = "input_textBox1";
            this.input_textBox1.Size = new System.Drawing.Size(289, 27);
            this.input_textBox1.TabIndex = 1;
            this.input_textBox1.UseWaitCursor = true;
            this.input_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_textBox1_KeyPress);
            //this.input_textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_textBox1_KeyUp);
            // 
            // answer_label1
            // 
            this.answer_label1.AutoSize = true;
            this.answer_label1.Location = new System.Drawing.Point(12, 125);
            this.answer_label1.Name = "answer_label1";
            this.answer_label1.Size = new System.Drawing.Size(289, 20);
            this.answer_label1.TabIndex = 2;
            this.answer_label1.Text = "Является ли введенное число простым?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Простой перебор делителей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer_label1);
            this.Controls.Add(this.input_textBox1);
            this.Controls.Add(this.check_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button check_button1;
        private TextBox input_textBox1;
        private Label answer_label1;
        private Button button1;
    }
}