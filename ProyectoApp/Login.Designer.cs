﻿namespace ProyectoApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label4 = new Label();
            button1 = new Button();
            checkMostrar = new CheckBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            label1 = new Label();
            label5 = new Label();
            btnRegistrarme = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(126, 399);
            label4.Name = "label4";
            label4.Size = new Size(126, 16);
            label4.TabIndex = 16;
            label4.Text = "¿No estás registrado?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(135, 343);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 15;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkMostrar
            // 
            checkMostrar.AutoSize = true;
            checkMostrar.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            checkMostrar.Location = new Point(236, 290);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(134, 20);
            checkMostrar.TabIndex = 14;
            checkMostrar.Text = "Mostrar Contraseña";
            checkMostrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(139, 136);
            label3.Name = "label3";
            label3.Size = new Size(104, 46);
            label3.TabIndex = 13;
            label3.Text = "Login";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.WhiteSmoke;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(126, 251);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(209, 23);
            txtContraseña.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 187);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 10;
            label1.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HP Simplified", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 253);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 18;
            label5.Text = "Contraseña";
            // 
            // btnRegistrarme
            // 
            btnRegistrarme.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistrarme.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarme.ForeColor = Color.Black;
            btnRegistrarme.Location = new Point(135, 428);
            btnRegistrarme.Name = "btnRegistrarme";
            btnRegistrarme.Size = new Size(108, 34);
            btnRegistrarme.TabIndex = 19;
            btnRegistrarme.Text = "Registrarme";
            btnRegistrarme.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(126, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 474);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnRegistrarme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkMostrar);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button button1;
        private CheckBox checkMostrar;
        private Label label3;
        private TextBox txtContraseña;
        private Label label1;
        private Label label5;
        private Button btnRegistrarme;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}