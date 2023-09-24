namespace ProyectoApp
{
    partial class Numero3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero3));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            btnNumTresBack = new Button();
            btnNumTresNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 322);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 1;
            label1.Text = "Tres";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 28);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNumTresBack
            // 
            btnNumTresBack.Location = new Point(24, 441);
            btnNumTresBack.Name = "btnNumTresBack";
            btnNumTresBack.Size = new Size(75, 23);
            btnNumTresBack.TabIndex = 3;
            btnNumTresBack.Text = "Atrás";
            btnNumTresBack.UseVisualStyleBackColor = true;
            // 
            // btnNumTresNext
            // 
            btnNumTresNext.Location = new Point(265, 441);
            btnNumTresNext.Name = "btnNumTresNext";
            btnNumTresNext.Size = new Size(75, 23);
            btnNumTresNext.TabIndex = 4;
            btnNumTresNext.Text = "Siguiente";
            btnNumTresNext.UseVisualStyleBackColor = true;
            // 
            // Numero3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(352, 475);
            Controls.Add(btnNumTresNext);
            Controls.Add(btnNumTresBack);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero3";
            Text = "Numero3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnNumTresBack;
        private Button btnNumTresNext;
    }
}