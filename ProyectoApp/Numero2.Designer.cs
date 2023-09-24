namespace ProyectoApp
{
    partial class Numero2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnDosNext = new Button();
            btnDosBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 323);
            label1.Name = "label1";
            label1.Size = new Size(42, 24);
            label1.TabIndex = 1;
            label1.Text = "Dos";
            // 
            // btnDosNext
            // 
            btnDosNext.Location = new Point(267, 415);
            btnDosNext.Name = "btnDosNext";
            btnDosNext.Size = new Size(75, 23);
            btnDosNext.TabIndex = 2;
            btnDosNext.Text = "Siguiente";
            btnDosNext.UseVisualStyleBackColor = true;
            // 
            // btnDosBack
            // 
            btnDosBack.Location = new Point(12, 415);
            btnDosBack.Name = "btnDosBack";
            btnDosBack.Size = new Size(75, 23);
            btnDosBack.TabIndex = 3;
            btnDosBack.Text = "Atrás";
            btnDosBack.UseVisualStyleBackColor = true;
            btnDosBack.Click += btnDosBack_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 23);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Numero2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 249, 248);
            ClientSize = new Size(354, 450);
            Controls.Add(button1);
            Controls.Add(btnDosBack);
            Controls.Add(btnDosNext);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Numero2";
            Text = "Numero2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDosNext;
        private Button btnDosBack;
        private Button button1;
    }
}