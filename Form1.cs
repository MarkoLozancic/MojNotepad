using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MojNotepad
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(this.richTextBox.Font, FontStyle.Underline);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog1.FileName+".txt");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chars = "2346789ABCDEFGHJKLMNPQRTUVWXYZabcdefghjkmnpqrtuvwxyz";
            Random rnd = new Random();
            string name;
            do
            {
                name = string.Empty;
                while (name.Length < 5)
                {
                    name += chars.Substring(rnd.Next(chars.Length), 1);
                }
                name += ".txt";
            } while (File.Exists(Path.Combine(@"C:\Temp\", name)));
            richTextBox.LoadFile(@"C:\Temp\"+name, RichTextBoxStreamType.RichText);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
             
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(this.richTextBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(this.richTextBox.Font, FontStyle.Underline);
        }
    }
}
