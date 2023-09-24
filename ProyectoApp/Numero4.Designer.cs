namespace ProyectoApp
{
    partial class Numero4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero4));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnNumCuatroClose = new Button();
            btnNumCuatroBack = new Button();
            btnNumCuatroNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 326);
            label1.Name = "label1";
            label1.Size = new Size(88, 31);
            label1.TabIndex = 1;
            label1.Text = "Cuatro";
            // 
            // btnNumCuatroClose
            // 
            btnNumCuatroClose.BackColor = Color.Red;
            btnNumCuatroClose.FlatStyle = FlatStyle.Flat;
            btnNumCuatroClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumCuatroClose.Location = new Point(12, 12);
            btnNumCuatroClose.Name = "btnNumCuatroClose";
            btnNumCuatroClose.Size = new Size(38, 27);
            btnNumCuatroClose.TabIndex = 2;
            btnNumCuatroClose.Text = "X";
            btnNumCuatroClose.UseVisualStyleBackColor = false;
            btnNumCuatroClose.Click += btnNumCuatroClose_Click;
            // 
            // btnNumCuatroBack
            // 
            btnNumCuatroBack.Location = new Point(12, 428);
            btnNumCuatroBack.Name = "btnNumCuatroBack";
            btnNumCuatroBack.Size = new Size(75, 23);
            btnNumCuatroBack.TabIndex = 3;
            btnNumCuatroBack.Text = "Atrás";
            btnNumCuatroBack.UseVisualStyleBackColor = true;
            btnNumCuatroBack.Click += btnNumCuatroBack_Click;
            // 
            // btnNumCuatroNext
            // 
            btnNumCuatroNext.Location = new Point(258, 428);
            btnNumCuatroNext.Name = "btnNumCuatroNext";
            btnNumCuatroNext.Size = new Size(75, 23);
            btnNumCuatroNext.TabIndex = 4;
            btnNumCuatroNext.Text = "Siguiente";
            btnNumCuatroNext.UseVisualStyleBackColor = true;
            btnNumCuatroNext.Click += btnNumCuatroNext_Click;
            // 
            // Numero4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(345, 463);
            Controls.Add(btnNumCuatroNext);
            Controls.Add(btnNumCuatroBack);
            Controls.Add(btnNumCuatroClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero4";
            Text = "Numero4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnNumCuatroClose;
        private Button btnNumCuatroBack;
        private Button btnNumCuatroNext;
    }
}