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
            btnUnoNext = new Button();
            btnUnoBack = new Button();
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
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 310);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 1;
            label1.Text = "Uno";
            // 
            // btnUnoCerrar
            // 
            btnUnoCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnUnoCerrar.FlatStyle = FlatStyle.Flat;
            btnUnoCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnoCerrar.Location = new Point(6, 9);
            btnUnoCerrar.Name = "btnUnoCerrar";
            btnUnoCerrar.Size = new Size(30, 23);
            btnUnoCerrar.TabIndex = 2;
            btnUnoCerrar.Text = "X";
            btnUnoCerrar.UseVisualStyleBackColor = false;
            btnUnoCerrar.Click += btnUnoCerrar_Click;
            // 
            // btnUnoNext
            // 
            btnUnoNext.Location = new Point(277, 415);
            btnUnoNext.Name = "btnUnoNext";
            btnUnoNext.Size = new Size(75, 23);
            btnUnoNext.TabIndex = 3;
            btnUnoNext.Text = "Siguiente";
            btnUnoNext.UseVisualStyleBackColor = true;
            btnUnoNext.Click += btnUnoNext_Click;
            // 
            // btnUnoBack
            // 
            btnUnoBack.Location = new Point(12, 415);
            btnUnoBack.Name = "btnUnoBack";
            btnUnoBack.Size = new Size(75, 23);
            btnUnoBack.TabIndex = 4;
            btnUnoBack.Text = "Atrás";
            btnUnoBack.UseVisualStyleBackColor = true;
            btnUnoBack.Click += btnUnoBack_Click;
            // 
            // Numero1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(364, 450);
            Controls.Add(btnUnoBack);
            Controls.Add(btnUnoNext);
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
        private Button btnUnoNext;
        private Button btnUnoBack;
    }
}