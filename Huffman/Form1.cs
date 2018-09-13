using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZakoduj_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                var saveFile = new SaveFileDialog();
                saveFile.ShowDialog();
                var fileName = saveFile.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                try
                {
                    var sw = new StreamWriter(fs);
                    HuffmanTree huffmanTree = new HuffmanTree();

                    // Build the Huffman tree
                    huffmanTree.Build(richTextBox1.Text);

                    // Encode
                    BitArray encoded = huffmanTree.Encode(richTextBox1.Text);

                    string encodedS = "";
                    foreach (bool bit in encoded)
                    {
                        encodedS += (bit ? 1 : 0) + "";
                    }
                    Node.setCodeToTheTree("", huffmanTree.Root);
                    // Writing symbols
                    huffmanTree.PrintfLeafAndCodes(huffmanTree.Root);
                    string symbols = "";
                    var bity_slownika = 0;
                    foreach (var node in huffmanTree.nodesToWrite)
                    {
                        symbols += node.Symbol + node.Code + ";";
                        bity_slownika += 8 + node.Code.Length;
                    }
                    
                    sw.WriteLine(symbols);
                    sw.WriteLine(encodedS);

                    var wynikForm = new Wynik_Kodowania_form(richTextBox1.Text, encodedS, symbols, huffmanTree.nodesToWrite,bity_slownika);
                    //  var zajetosc = sizeof(char) * txtBoxHaslo.Text.Length * 8;// bo sizeof podaje w bajtach a chcemy bity
                    //   MessageBox.Show("Nie zakodowany tekst zajmuje "+zajetosc.ToString()+" bitów");
                   wynikForm.ShowDialog();
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Wpisz hasło do zakodowania");
            }
        }

        private void btnDekoduj_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            var res = openFile.ShowDialog();
            var fileName = openFile.FileName;
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                StreamReader sr = new StreamReader(fs);

                var dictionaryCodes = sr.ReadLine();
                //tutaj tworzenie słownika
                var dictionary = new Dictionary<char, string>();
                while (dictionaryCodes != string.Empty)
                {
                    var sign = dictionaryCodes.ElementAt(0);
                    int i = 1;
                    var code = "";
                    while (dictionaryCodes[i] != ';')
                    {
                        code += dictionaryCodes[i];
                        i++;
                    }
                    dictionary.Add(sign, code);
                    dictionaryCodes = dictionaryCodes.Remove(0, i + 1);
                }

                var text = sr.ReadLine();
                //dekodowanie na podstawie słownika
                var zdekodowany = "";
                while (text != string.Empty)
                {
                    foreach (var word in dictionary)
                    {
                        if (text.StartsWith(word.Value))
                        {
                            zdekodowany += word.Key;
                            text = text.Remove(0, word.Value.Length);
                            break;
                        }
                    }
                }

                sr.Close();
                MessageBox.Show(zdekodowany);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Liczba znaków to:" + richTextBox1.Text.Length.ToString();
        }
    }
}
