namespace ProyectoApp
{
    partial class LetraF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraF));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRegresarF = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnRegresarF
            // 
            btnRegresarF.BackColor = Color.Gainsboro;
            btnRegresarF.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresarF.Location = new Point(130, 399);
            btnRegresarF.Name = "btnRegresarF";
            btnRegresarF.Size = new Size(77, 32);
            btnRegresarF.TabIndex = 14;
            btnRegresarF.Text = "Regresar";
            btnRegresarF.UseVisualStyleBackColor = false;
            // 
            // LetraF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(336, 442);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnRegresarF);
            MaximizeBox = false;
            Name = "LetraF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LetraF";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnRegresarF;
    }
}