using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuStats
{
    public partial class DocuStats : Form
    {
        int chars, charsNo, words, lines, parag;

        public DocuStats()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                textBox1.Text = file;

                chars = charsNo = words = lines = parag = 0;

                StreamReader reader = new StreamReader(file);
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line == "")
                    {
                        parag++;
                    }
                    else
                    {
                        foreach (char item in line)
                        {
                            int asciiCode = (int)item;
                            if (asciiCode != 10 && asciiCode != 13 && asciiCode != 32)
                            {
                                charsNo++;
                            }
                            chars++;
                        }
                        words += line.Split(' ').Length;
                    }    
                    lines++;                    

                    line = reader.ReadLine();
                }
                parag++;
            }
            ShowResults();
        }

        private void ShowResults()
        {
            charsLabel.Text = chars.ToString();
            charsNoLabel.Text = charsNo.ToString();
            wordsLabel.Text = words.ToString();
            linesLabel.Text = lines.ToString();
            paragLabel.Text = parag.ToString();
        }
    }
}
