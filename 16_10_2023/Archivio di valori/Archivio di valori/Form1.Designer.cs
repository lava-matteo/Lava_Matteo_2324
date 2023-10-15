namespace Archivio_di_valori
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
            Archivio = new ListBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // Archivio
            // 
            Archivio.FormattingEnabled = true;
            Archivio.ItemHeight = 15;
            Archivio.Location = new Point(367, 12);
            Archivio.Name = "Archivio";
            Archivio.Size = new Size(331, 364);
            Archivio.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(221, 79);
            button1.Name = "button1";
            button1.Size = new Size(113, 27);
            button1.TabIndex = 1;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 196);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Massimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Minimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 154);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 6;
            label4.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 308);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Somma a tutti: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 196);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 8;
            label6.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 262);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 9;
            label7.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 262);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 10;
            label8.Text = "Occorrenze di:";
            // 
            // button2
            // 
            button2.Location = new Point(221, 302);
            button2.Name = "button2";
            button2.Size = new Size(113, 27);
            button2.TabIndex = 11;
            button2.Text = "Esegui";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(252, 259);
            button3.Name = "button3";
            button3.Size = new Size(57, 27);
            button3.TabIndex = 14;
            button3.Text = "Cerca";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 388);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Archivio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Archivio;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
    }
}