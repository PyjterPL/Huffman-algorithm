using System.Collections.Generic;
using System;
namespace Huffman
{
    public partial class Wynik_Kodowania_form
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
        public Wynik_Kodowania_form(string text, string encodedText, string dictionary, List<Node> nodes,int bity_slownika)
        {
            InitializeComponent();

            foreach (var node in nodes)
            {
                dataGridView1.Rows.Add(node.Symbol, node.Code, node.Frequency);
            }
            richTextBox1.Text = "Kodowane słowo to:\"" + text + "\"";
            var zajetosc = sizeof(char) * text.Length * 8;// bo sizeof podaje w bajtach a chcemy bity
            label2.Text = "Nie zakodowany tekst zajmuje " + zajetosc.ToString() + " bitów";
            label3.Text = "Zakodowany text zajmuje " + encodedText.Length.ToString() + " bitów (bez słownika)";
            label4.Text = "Zakodowany text zajmuje " + (encodedText.Length + bity_slownika).ToString() + " bitów (ze słownikiem)";
            //float procent_kompresji =0 ;//zajetosc/(zajetosc-((float)encodedText.Length + (float)bity_slownika));///(float)((float)zajetosc / ((float)encodedText.Length + (float)bity_slownika));
           var roznica = zajetosc-((float)encodedText.Length + (float)bity_slownika);
           var procent_kompresji = (float)(roznica / zajetosc) * 100;
            
            label1.Text = "Procent kompresji ze slownikiem to: "+procent_kompresji.ToString()+"%";
            var roznica_bez_slownika = zajetosc - ((float)encodedText.Length);
            var procent_kompresji_bez_slownika = (float)(roznica_bez_slownika / zajetosc) * 100;
            label5.Text = "Procent kompresji bez slownika to: " + procent_kompresji_bez_slownika.ToString() + "%";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //label1.Text = "Liczba znaków to " + richTextBox1.Text.Length.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 168);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Code,
            this.Frequency});
            this.dataGridView1.Location = new System.Drawing.Point(16, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 228);
            this.dataGridView1.TabIndex = 5;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Kod";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Częstość";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // Wynik_Kodowania_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 521);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Wynik_Kodowania_form";
            this.Text = "Wynik_Kodowania_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.Label label5;
    }
}