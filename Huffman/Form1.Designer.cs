namespace Huffman
{
    partial class Form1
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
            this.btnDekoduj = new System.Windows.Forms.Button();
            this.btnZakoduj = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDekoduj
            // 
            this.btnDekoduj.Location = new System.Drawing.Point(13, 13);
            this.btnDekoduj.Name = "btnDekoduj";
            this.btnDekoduj.Size = new System.Drawing.Size(267, 23);
            this.btnDekoduj.TabIndex = 0;
            this.btnDekoduj.Text = "Dekoduj";
            this.btnDekoduj.UseVisualStyleBackColor = true;
            this.btnDekoduj.Click += new System.EventHandler(this.btnDekoduj_Click);
            // 
            // btnZakoduj
            // 
            this.btnZakoduj.Location = new System.Drawing.Point(13, 238);
            this.btnZakoduj.Name = "btnZakoduj";
            this.btnZakoduj.Size = new System.Drawing.Size(267, 23);
            this.btnZakoduj.TabIndex = 1;
            this.btnZakoduj.Text = "Zakoduj";
            this.btnZakoduj.UseVisualStyleBackColor = true;
            this.btnZakoduj.Click += new System.EventHandler(this.btnZakoduj_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 189);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba znaków to: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnZakoduj);
            this.Controls.Add(this.btnDekoduj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDekoduj;
        private System.Windows.Forms.Button btnZakoduj;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

