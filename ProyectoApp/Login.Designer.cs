namespace ProyectoApp
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
            btnAcceder = new Button();
            btnRegistrarme = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkMostrarContraseña = new CheckBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(128, 128, 255);
            btnAcceder.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.Location = new Point(158, 347);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(76, 34);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarme
            // 
            btnRegistrarme.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistrarme.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarme.Location = new Point(260, 421);
            btnRegistrarme.Name = "btnRegistrarme";
            btnRegistrarme.Size = new Size(95, 36);
            btnRegistrarme.TabIndex = 1;
            btnRegistrarme.Text = "Registrarme";
            btnRegistrarme.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 217);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 275);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(156, 152);
            label3.Name = "label3";
            label3.Size = new Size(104, 46);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // chkMostrarContraseña
            // 
            chkMostrarContraseña.AutoSize = true;
            chkMostrarContraseña.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarContraseña.Location = new Point(242, 314);
            chkMostrarContraseña.Name = "chkMostrarContraseña";
            chkMostrarContraseña.Size = new Size(134, 20);
            chkMostrarContraseña.TabIndex = 6;
            chkMostrarContraseña.Text = "Mostrar Contraseña";
            chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 432);
            label4.Name = "label4";
            label4.Size = new Size(126, 16);
            label4.TabIndex = 7;
            label4.Text = "¿No estás registrado?";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(181, 216);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 23);
            txtUsuario.TabIndex = 8;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.WhiteSmoke;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("HP Simplified", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(181, 274);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(154, 23);
            txtContraseña.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 479);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(chkMostrarContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarme);
            Controls.Add(btnAcceder);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Button btnRegistrarme;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkMostrarContraseña;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}