namespace Temporary_Cleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(198, 29);
            button1.TabIndex = 0;
            button1.Text = "Win Temp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 47);
            button2.Name = "button2";
            button2.Size = new Size(198, 29);
            button2.TabIndex = 1;
            button2.Text = "AppData Local Temp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 82);
            button3.Name = "button3";
            button3.Size = new Size(198, 29);
            button3.TabIndex = 2;
            button3.Text = "Win Prefetch";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 117);
            button4.Name = "button4";
            button4.Size = new Size(198, 29);
            button4.TabIndex = 3;
            button4.Text = "INetCache";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 152);
            button5.Name = "button5";
            button5.Size = new Size(198, 29);
            button5.TabIndex = 4;
            button5.Text = "Software Distribution";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 187);
            button6.Name = "button6";
            button6.Size = new Size(198, 29);
            button6.TabIndex = 5;
            button6.Text = "Windows Log";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 311);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Version 2.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 333);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 8;
            label2.Text = "By Design System";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 363);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(358, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpieza Completa Automatica";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 222);
            button7.Name = "button7";
            button7.Size = new Size(198, 29);
            button7.TabIndex = 10;
            button7.Text = "History";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 257);
            button8.Name = "button8";
            button8.Size = new Size(198, 29);
            button8.TabIndex = 11;
            button8.Text = "AppData Roaming Recent";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(221, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 398);
            Controls.Add(pictureBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 445);
            MinimumSize = new Size(400, 445);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Temporary Cleaner 2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnLimpiar;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox2;
    }
}