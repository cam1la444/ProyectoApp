namespace ProyectoApp
{
    partial class Abecedario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnA = new Button();
            SuspendLayout();
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(192, 192, 255);
            btnA.BackgroundImageLayout = ImageLayout.Center;
            btnA.Cursor = Cursors.Hand;
            btnA.FlatStyle = FlatStyle.Popup;
            btnA.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            btnA.ForeColor = Color.Navy;
            btnA.Location = new Point(232, 12);
            btnA.Name = "btnA";
            btnA.Size = new Size(173, 121);
            btnA.TabIndex = 2;
            btnA.Text = "A";
            btnA.TextAlign = ContentAlignment.BottomRight;
            btnA.UseVisualStyleBackColor = false;
            // 
            // Abecedario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnA);
            Name = "Abecedario";
            Text = "Abecedario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnA;
    }
}