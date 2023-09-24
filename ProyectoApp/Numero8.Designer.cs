namespace ProyectoApp
{
    partial class Numero8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero8));
            pictureBox1 = new PictureBox();
            btnNumOchoBack = new Button();
            btnNumOchoNext = new Button();
            btnNumOchoClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNumOchoBack
            // 
            btnNumOchoBack.Location = new Point(21, 415);
            btnNumOchoBack.Name = "btnNumOchoBack";
            btnNumOchoBack.Size = new Size(75, 23);
            btnNumOchoBack.TabIndex = 1;
            btnNumOchoBack.Text = "Atrás";
            btnNumOchoBack.UseVisualStyleBackColor = true;
            btnNumOchoBack.Click += btnNumOchoBack_Click;
            // 
            // btnNumOchoNext
            // 
            btnNumOchoNext.Location = new Point(244, 415);
            btnNumOchoNext.Name = "btnNumOchoNext";
            btnNumOchoNext.Size = new Size(75, 23);
            btnNumOchoNext.TabIndex = 2;
            btnNumOchoNext.Text = "Siguiente";
            btnNumOchoNext.UseVisualStyleBackColor = true;
            btnNumOchoNext.Click += btnNumOchoNext_Click;
            // 
            // btnNumOchoClose
            // 
            btnNumOchoClose.BackColor = Color.Red;
            btnNumOchoClose.FlatStyle = FlatStyle.Flat;
            btnNumOchoClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumOchoClose.Location = new Point(12, 12);
            btnNumOchoClose.Name = "btnNumOchoClose";
            btnNumOchoClose.Size = new Size(28, 26);
            btnNumOchoClose.TabIndex = 3;
            btnNumOchoClose.Text = "X";
            btnNumOchoClose.UseVisualStyleBackColor = false;
            btnNumOchoClose.Click += btnNumOchoClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(131, 320);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 4;
            label1.Text = "Ocho";
            // 
            // Numero8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(331, 450);
            Controls.Add(label1);
            Controls.Add(btnNumOchoClose);
            Controls.Add(btnNumOchoNext);
            Controls.Add(btnNumOchoBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero8";
            Text = "Numero8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNumOchoBack;
        private Button btnNumOchoNext;
        private Button btnNumOchoClose;
        private Label label1;
    }
}