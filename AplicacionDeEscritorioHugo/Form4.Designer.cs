namespace AplicacionDeEscritorioHugo2
{
    partial class Form4
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
            listBox1 = new ListBox();
            pictureBox7 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "LUIS CAMPOSANO", "NACHO", "ERICK" });
            listBox1.Location = new Point(40, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(398, 259);
            listBox1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources.borde;
            pictureBox7.Location = new Point(741, 206);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(178, 281);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 58, 83);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 58, 83);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 58, 83);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(755, 32);
            button1.Name = "button1";
            button1.Size = new Size(143, 60);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(773, 40);
            button2.Name = "button2";
            button2.Size = new Size(106, 43);
            button2.TabIndex = 13;
            button2.Text = "CARGOS";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.CausesValidation = false;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(40, 417);
            button5.Name = "button5";
            button5.Size = new Size(68, 31);
            button5.TabIndex = 15;
            button5.Text = "ATRAS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.CausesValidation = false;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(40, 366);
            button4.Name = "button4";
            button4.Size = new Size(68, 31);
            button4.TabIndex = 14;
            button4.Text = "INICIO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 95, 134);
            ClientSize = new Size(913, 499);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox7);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox7;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
    }
}