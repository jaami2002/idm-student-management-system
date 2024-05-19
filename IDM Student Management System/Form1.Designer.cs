namespace IDM_Student_Management_System
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 22);
            label1.Name = "label1";
            label1.Size = new Size(528, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome to IDM Nations Campus";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.idm2;
            pictureBox1.Location = new Point(338, 89);
            pictureBox1.MaximumSize = new Size(255, 200);
            pictureBox1.MinimumSize = new Size(150, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 247);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 303);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(413, 437);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(507, 437);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(725, 437);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 8;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(834, 512);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximumSize = new Size(1000, 1000);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}