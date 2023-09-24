namespace ProyectoApp
{
    partial class LetraD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraD));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRegresarD = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnRegresarD
            // 
            btnRegresarD.BackColor = Color.Gainsboro;
            btnRegresarD.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresarD.Location = new Point(130, 401);
            btnRegresarD.Name = "btnRegresarD";
            btnRegresarD.Size = new Size(77, 32);
            btnRegresarD.TabIndex = 14;
            btnRegresarD.Text = "Regresar";
            btnRegresarD.UseVisualStyleBackColor = false;
            btnRegresarD.Click += btnRegresarD_Click;
            // 
            // LetraD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(337, 446);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnRegresarD);
            MaximizeBox = false;
            Name = "LetraD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LetraD";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnRegresarD;
    }
}