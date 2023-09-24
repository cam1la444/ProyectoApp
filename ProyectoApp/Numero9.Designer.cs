namespace ProyectoApp
{
    partial class Numero9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero9));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnNumNueveBack = new Button();
            btnNumNueveNext = new Button();
            btnNumNueveClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 281);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 1;
            label1.Text = "Nueve";
            // 
            // btnNumNueveBack
            // 
            btnNumNueveBack.Location = new Point(12, 420);
            btnNumNueveBack.Name = "btnNumNueveBack";
            btnNumNueveBack.Size = new Size(75, 23);
            btnNumNueveBack.TabIndex = 2;
            btnNumNueveBack.Text = "Atrás";
            btnNumNueveBack.UseVisualStyleBackColor = true;
            // 
            // btnNumNueveNext
            // 
            btnNumNueveNext.Location = new Point(253, 420);
            btnNumNueveNext.Name = "btnNumNueveNext";
            btnNumNueveNext.Size = new Size(75, 23);
            btnNumNueveNext.TabIndex = 3;
            btnNumNueveNext.Text = "Siguiente";
            btnNumNueveNext.UseVisualStyleBackColor = true;
            // 
            // btnNumNueveClose
            // 
            btnNumNueveClose.BackColor = Color.Red;
            btnNumNueveClose.FlatStyle = FlatStyle.Flat;
            btnNumNueveClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumNueveClose.Location = new Point(17, 11);
            btnNumNueveClose.Name = "btnNumNueveClose";
            btnNumNueveClose.Size = new Size(75, 23);
            btnNumNueveClose.TabIndex = 4;
            btnNumNueveClose.Text = "X";
            btnNumNueveClose.UseVisualStyleBackColor = false;
            // 
            // Numero9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(340, 455);
            Controls.Add(btnNumNueveClose);
            Controls.Add(btnNumNueveNext);
            Controls.Add(btnNumNueveBack);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero9";
            Text = "Numero9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnNumNueveBack;
        private Button btnNumNueveNext;
        private Button btnNumNueveClose;
    }
}