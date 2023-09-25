namespace ProyectoApp
{
    partial class Numero6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero6));
            pictureBox1 = new PictureBox();
            btnNumSeisBack = new Button();
            btnNumSeisNext = new Button();
            btnNumSeisClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNumSeisBack
            // 
            btnNumSeisBack.Location = new Point(23, 413);
            btnNumSeisBack.Name = "btnNumSeisBack";
            btnNumSeisBack.Size = new Size(75, 23);
            btnNumSeisBack.TabIndex = 1;
            btnNumSeisBack.Text = "Atrás";
            btnNumSeisBack.UseVisualStyleBackColor = true;
            // 
            // btnNumSeisNext
            // 
            btnNumSeisNext.Location = new Point(257, 415);
            btnNumSeisNext.Name = "btnNumSeisNext";
            btnNumSeisNext.Size = new Size(75, 23);
            btnNumSeisNext.TabIndex = 2;
            btnNumSeisNext.Text = "Siguiente";
            btnNumSeisNext.UseVisualStyleBackColor = true;
            // 
            // btnNumSeisClose
            // 
            btnNumSeisClose.BackColor = Color.Red;
            btnNumSeisClose.FlatStyle = FlatStyle.Flat;
            btnNumSeisClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSeisClose.Location = new Point(13, 15);
            btnNumSeisClose.Name = "btnNumSeisClose";
            btnNumSeisClose.Size = new Size(35, 28);
            btnNumSeisClose.TabIndex = 3;
            btnNumSeisClose.Text = "X";
            btnNumSeisClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 301);
            label1.Name = "label1";
            label1.Size = new Size(60, 31);
            label1.TabIndex = 4;
            label1.Text = "Seis";
            // 
            // Numero6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(344, 450);
            Controls.Add(label1);
            Controls.Add(btnNumSeisClose);
            Controls.Add(btnNumSeisNext);
            Controls.Add(btnNumSeisBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero6";
            Text = "Numero6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNumSeisBack;
        private Button btnNumSeisNext;
        private Button btnNumSeisClose;
        private Label label1;
    }
}