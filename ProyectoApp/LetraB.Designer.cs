namespace ProyectoApp
{
    partial class LetraB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraB));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSalirB = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnSalirB
            // 
            btnSalirB.BackColor = Color.Gainsboro;
            btnSalirB.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalirB.Location = new Point(139, 399);
            btnSalirB.Name = "btnSalirB";
            btnSalirB.Size = new Size(77, 32);
            btnSalirB.TabIndex = 2;
            btnSalirB.Text = "Salir";
            btnSalirB.UseVisualStyleBackColor = false;
            // 
            // LetraB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(343, 443);
            Controls.Add(btnSalirB);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "LetraB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LetraA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSalirB;
    }
}