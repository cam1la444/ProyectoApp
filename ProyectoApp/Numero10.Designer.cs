namespace ProyectoApp
{
    partial class Numero10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero10));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnNumDiezBack = new Button();
            btnNumDiezNext = new Button();
            btnNumDiezClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 291);
            label1.Name = "label1";
            label1.Size = new Size(63, 31);
            label1.TabIndex = 1;
            label1.Text = "Diez";
            // 
            // btnNumDiezBack
            // 
            btnNumDiezBack.Location = new Point(12, 415);
            btnNumDiezBack.Name = "btnNumDiezBack";
            btnNumDiezBack.Size = new Size(75, 23);
            btnNumDiezBack.TabIndex = 2;
            btnNumDiezBack.Text = "Atrás";
            btnNumDiezBack.UseVisualStyleBackColor = true;
            btnNumDiezBack.Click += btnNumDiezBack_Click;
            // 
            // btnNumDiezNext
            // 
            btnNumDiezNext.Location = new Point(240, 415);
            btnNumDiezNext.Name = "btnNumDiezNext";
            btnNumDiezNext.Size = new Size(75, 23);
            btnNumDiezNext.TabIndex = 3;
            btnNumDiezNext.Text = "Siguiente";
            btnNumDiezNext.UseVisualStyleBackColor = true;
            btnNumDiezNext.Click += btnNumDiezNext_Click;
            // 
            // btnNumDiezClose
            // 
            btnNumDiezClose.BackColor = Color.Red;
            btnNumDiezClose.FlatStyle = FlatStyle.Flat;
            btnNumDiezClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumDiezClose.Location = new Point(12, 12);
            btnNumDiezClose.Name = "btnNumDiezClose";
            btnNumDiezClose.Size = new Size(30, 27);
            btnNumDiezClose.TabIndex = 4;
            btnNumDiezClose.Text = "X";
            btnNumDiezClose.UseVisualStyleBackColor = false;
            btnNumDiezClose.Click += btnNumDiezClose_Click;
            // 
            // Numero10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(327, 450);
            Controls.Add(btnNumDiezClose);
            Controls.Add(btnNumDiezNext);
            Controls.Add(btnNumDiezBack);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero10";
            Text = "Numero10";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnNumDiezBack;
        private Button btnNumDiezNext;
        private Button btnNumDiezClose;
    }
}