namespace ProyectoApp
{
    partial class LetraG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraG));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRegresarG = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnRegresarG
            // 
            btnRegresarG.BackColor = Color.Gainsboro;
            btnRegresarG.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresarG.Location = new Point(130, 400);
            btnRegresarG.Name = "btnRegresarG";
            btnRegresarG.Size = new Size(77, 32);
            btnRegresarG.TabIndex = 14;
            btnRegresarG.Text = "Regresar";
            btnRegresarG.UseVisualStyleBackColor = false;
            btnRegresarG.Click += btnRegresarG_Click;
            // 
            // LetraG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(336, 444);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnRegresarG);
            MaximizeBox = false;
            Name = "LetraG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LetraG";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnRegresarG;
    }
}