namespace AplicacionDeEscritorioHugo2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(-4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(922, 116);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(-4, -12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(922, 136);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(234, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 52);
            textBox1.TabIndex = 2;
            textBox1.Text = "NOMBRE y APELLIDO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(334, 253);
            button1.Name = "button1";
            button1.Size = new Size(280, 46);
            button1.TabIndex = 3;
            button1.Text = "DATOS PERSONALES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.CausesValidation = false;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(334, 333);
            button2.Name = "button2";
            button2.Size = new Size(280, 46);
            button2.TabIndex = 4;
            button2.Text = "TRAYECTORIA";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.CausesValidation = false;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(334, 412);
            button3.Name = "button3";
            button3.Size = new Size(280, 46);
            button3.TabIndex = 5;
            button3.Text = "LEGAJO";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.CausesValidation = false;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(38, 376);
            button4.Name = "button4";
            button4.Size = new Size(68, 31);
            button4.TabIndex = 6;
            button4.Text = "INICIO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.CausesValidation = false;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(38, 427);
            button5.Name = "button5";
            button5.Size = new Size(68, 31);
            button5.TabIndex = 7;
            button5.Text = "ATRAS";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.borde;
            pictureBox7.Location = new Point(740, 225);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(178, 281);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.Image = Properties.Resources.Libro;
            pictureBox3.Location = new Point(29, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(188, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 95, 134);
            ClientSize = new Size(909, 495);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
    }
}