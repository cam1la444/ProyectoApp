namespace ProyectoApp
{
    partial class LetraE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetraE));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRegresarE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // btnRegresarE
            // 
            btnRegresarE.BackColor = Color.Gainsboro;
            btnRegresarE.Font = new Font("HP Simplified", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresarE.Location = new Point(131, 401);
            btnRegresarE.Name = "btnRegresarE";
            btnRegresarE.Size = new Size(77, 32);
            btnRegresarE.TabIndex = 11;
            btnRegresarE.Text = "Regresar";
            btnRegresarE.UseVisualStyleBackColor = false;
            btnRegresarE.Click += btnRegresarE_Click;
            // 
            // LetraE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(340, 446);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnRegresarE);
            MaximizeBox = false;
            Name = "LetraE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LetraE";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnRegresarE;
    }
}