namespace ProyectoApp
{
    partial class Número0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Número0));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCeroClose = new Button();
            btnCeroSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 313);
            label1.Name = "label1";
            label1.Size = new Size(64, 31);
            label1.TabIndex = 1;
            label1.Text = "Cero";
            // 
            // btnCeroClose
            // 
            btnCeroClose.BackColor = Color.FromArgb(192, 0, 0);
            btnCeroClose.FlatStyle = FlatStyle.Flat;
            btnCeroClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCeroClose.Location = new Point(10, 11);
            btnCeroClose.Name = "btnCeroClose";
            btnCeroClose.Size = new Size(29, 23);
            btnCeroClose.TabIndex = 2;
            btnCeroClose.Text = "X";
            btnCeroClose.UseVisualStyleBackColor = false;
            btnCeroClose.Click += btnCeroClose_Click;
            // 
            // btnCeroSiguiente
            // 
            btnCeroSiguiente.Location = new Point(267, 415);
            btnCeroSiguiente.Name = "btnCeroSiguiente";
            btnCeroSiguiente.Size = new Size(75, 23);
            btnCeroSiguiente.TabIndex = 3;
            btnCeroSiguiente.Text = "Siguiente";
            btnCeroSiguiente.UseVisualStyleBackColor = true;
            btnCeroSiguiente.Click += btnCeroSiguiente_Click;
            // 
            // Número0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(354, 450);
            Controls.Add(btnCeroSiguiente);
            Controls.Add(btnCeroClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Número0";
            Text = "Número0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCeroClose;
        private Button btnCeroSiguiente;
    }
}