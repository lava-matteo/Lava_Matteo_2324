namespace Gestione_Videogiochi
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            max = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            min = new Label();
            average = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Titolo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox7 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(384, 424);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(411, 179);
            button1.Name = "button1";
            button1.Size = new Size(124, 32);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(411, 255);
            button2.Name = "button2";
            button2.Size = new Size(124, 32);
            button2.TabIndex = 2;
            button2.Text = "Rimuovi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            max.Location = new Point(413, 348);
            max.Name = "max";
            max.Size = new Size(122, 20);
            max.TabIndex = 3;
            max.Text = "Prezzo più alto: x";
            // 
            // button3
            // 
            button3.Location = new Point(545, 179);
            button3.Name = "button3";
            button3.Size = new Size(124, 32);
            button3.TabIndex = 4;
            button3.Text = "Modifica";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(543, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 5;
            // 
            // min
            // 
            min.AutoSize = true;
            min.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            min.Location = new Point(413, 382);
            min.Name = "min";
            min.Size = new Size(134, 20);
            min.TabIndex = 6;
            min.Text = "Prezzo più basso: x";
            // 
            // average
            // 
            average.AutoSize = true;
            average.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            average.Location = new Point(413, 416);
            average.Name = "average";
            average.Size = new Size(114, 20);
            average.TabIndex = 7;
            average.Text = "Prezzo medio: x";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(543, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(543, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(102, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(714, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(596, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(61, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(472, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(63, 23);
            textBox6.TabIndex = 12;
            // 
            // Titolo
            // 
            Titolo.AutoSize = true;
            Titolo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Titolo.Location = new Point(424, 21);
            Titolo.Name = "Titolo";
            Titolo.Size = new Size(48, 20);
            Titolo.TabIndex = 13;
            Titolo.Text = "Titolo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 14;
            label2.Text = "Console";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(424, 79);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 15;
            label3.Text = "Prezzo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(412, 132);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 16;
            label4.Text = "Giorno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(546, 132);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 17;
            label5.Text = "Mese";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(664, 132);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 18;
            label6.Text = "Anno";
            // 
            // button4
            // 
            button4.Location = new Point(545, 255);
            button4.Name = "button4";
            button4.Size = new Size(124, 32);
            button4.TabIndex = 19;
            button4.Text = "Clona";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(411, 293);
            button5.Name = "button5";
            button5.Size = new Size(124, 32);
            button5.TabIndex = 20;
            button5.Text = "Svuota lista";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(664, 358);
            button6.Name = "button6";
            button6.Size = new Size(124, 32);
            button6.TabIndex = 21;
            button6.Text = "Filtra per console";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(664, 396);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(124, 23);
            textBox7.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(596, 399);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 23;
            label1.Text = "Console";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Titolo);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(average);
            Controls.Add(min);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(max);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label max;
        private Button button3;
        private TextBox textBox1;
        private Label min;
        private Label average;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label Titolo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox7;
        private Label label1;
    }
}