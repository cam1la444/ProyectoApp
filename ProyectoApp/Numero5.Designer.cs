namespace ProyectoApp
{
    partial class Numero5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero5));
            pictureBox1 = new PictureBox();
            btnNumCincoBack = new Button();
            btnNumCincoNext = new Button();
            btnNumCincoClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNumCincoBack
            // 
            btnNumCincoBack.Location = new Point(25, 405);
            btnNumCincoBack.Name = "btnNumCincoBack";
            btnNumCincoBack.Size = new Size(75, 23);
            btnNumCincoBack.TabIndex = 1;
            btnNumCincoBack.Text = "Atrás";
            btnNumCincoBack.UseVisualStyleBackColor = true;
            // 
            // btnNumCincoNext
            // 
            btnNumCincoNext.Location = new Point(265, 405);
            btnNumCincoNext.Name = "btnNumCincoNext";
            btnNumCincoNext.Size = new Size(75, 23);
            btnNumCincoNext.TabIndex = 2;
            btnNumCincoNext.Text = "Siguiente";
            btnNumCincoNext.UseVisualStyleBackColor = true;
            // 
            // btnNumCincoClose
            // 
            btnNumCincoClose.BackColor = Color.Red;
            btnNumCincoClose.FlatStyle = FlatStyle.Flat;
            btnNumCincoClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumCincoClose.Location = new Point(10, 10);
            btnNumCincoClose.Name = "btnNumCincoClose";
            btnNumCincoClose.Size = new Size(30, 27);
            btnNumCincoClose.TabIndex = 3;
            btnNumCincoClose.Text = "X";
            btnNumCincoClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 325);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 4;
            label1.Text = "Cinco";
            // 
            // Numero5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(352, 450);
            Controls.Add(label1);
            Controls.Add(btnNumCincoClose);
            Controls.Add(btnNumCincoNext);
            Controls.Add(btnNumCincoBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero5";
            Text = "Numero5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNumCincoBack;
        private Button btnNumCincoNext;
        private Button btnNumCincoClose;
        private Label label1;
    }
}