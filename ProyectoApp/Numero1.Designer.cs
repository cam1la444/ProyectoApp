namespace ProyectoApp
{
    partial class Numero1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnUnoCerrar = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(153, 320);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 1;
            label1.Text = "Uno";
            // 
            // btnUnoCerrar
            // 
            btnUnoCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnUnoCerrar.FlatStyle = FlatStyle.Flat;
            btnUnoCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnoCerrar.Location = new Point(322, 21);
            btnUnoCerrar.Name = "btnUnoCerrar";
            btnUnoCerrar.Size = new Size(30, 23);
            btnUnoCerrar.TabIndex = 2;
            btnUnoCerrar.Text = "X";
            btnUnoCerrar.UseVisualStyleBackColor = false;
            btnUnoCerrar.Click += btnUnoCerrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(137, 423);
            button1.Name = "button1";
            button1.Size = new Size(83, 31);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 379);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 6;
            button2.Text = "Atrás";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(268, 379);
            button4.Name = "button4";
            button4.Size = new Size(84, 31);
            button4.TabIndex = 8;
            button4.Text = "Siguiente";
            button4.UseVisualStyleBackColor = false;
            // 
            // Numero1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(364, 466);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnUnoCerrar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero1";
            Text = "Numero1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnUnoCerrar;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}