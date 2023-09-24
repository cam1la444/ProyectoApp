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
            btnNumDosClose = new Button();
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
            btnDosNext.Click += btnDosNext_Click;
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
            // btnNumDosClose
            // 
            btnNumDosClose.BackColor = Color.FromArgb(192, 0, 0);
            btnNumDosClose.FlatStyle = FlatStyle.Flat;
            btnNumDosClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumDosClose.Location = new Point(12, 12);
            btnNumDosClose.Name = "btnNumDosClose";
            btnNumDosClose.Size = new Size(32, 23);
            btnNumDosClose.TabIndex = 4;
            btnNumDosClose.Text = "X";
            btnNumDosClose.UseVisualStyleBackColor = false;
            btnNumDosClose.Click += btnNumDosClose_Click;
            // 
            // Numero2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(354, 450);
            Controls.Add(btnNumDosClose);
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
        private Button btnNumDosClose;
    }
}