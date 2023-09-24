namespace ProyectoApp
{
    partial class Numero7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero7));
            pictureBox1 = new PictureBox();
            btnNumSieteBack = new Button();
            btnNumSieteNext = new Button();
            btnNumSieteClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNumSieteBack
            // 
            btnNumSieteBack.Location = new Point(12, 415);
            btnNumSieteBack.Name = "btnNumSieteBack";
            btnNumSieteBack.Size = new Size(75, 23);
            btnNumSieteBack.TabIndex = 1;
            btnNumSieteBack.Text = "Atrás";
            btnNumSieteBack.UseVisualStyleBackColor = true;
            // 
            // btnNumSieteNext
            // 
            btnNumSieteNext.Location = new Point(243, 415);
            btnNumSieteNext.Name = "btnNumSieteNext";
            btnNumSieteNext.Size = new Size(75, 23);
            btnNumSieteNext.TabIndex = 2;
            btnNumSieteNext.Text = "Siguiente";
            btnNumSieteNext.UseVisualStyleBackColor = true;
            // 
            // btnNumSieteClose
            // 
            btnNumSieteClose.BackColor = Color.Red;
            btnNumSieteClose.FlatStyle = FlatStyle.Flat;
            btnNumSieteClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSieteClose.Location = new Point(17, 13);
            btnNumSieteClose.Name = "btnNumSieteClose";
            btnNumSieteClose.Size = new Size(24, 26);
            btnNumSieteClose.TabIndex = 3;
            btnNumSieteClose.Text = "X";
            btnNumSieteClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 303);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 4;
            label1.Text = "Siete";
            // 
            // Numero7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(330, 450);
            Controls.Add(label1);
            Controls.Add(btnNumSieteClose);
            Controls.Add(btnNumSieteNext);
            Controls.Add(btnNumSieteBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero7";
            Text = "Numero7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNumSieteBack;
        private Button btnNumSieteNext;
        private Button btnNumSieteClose;
        private Label label1;
    }
}