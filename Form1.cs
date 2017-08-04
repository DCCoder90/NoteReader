using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace NoteReader
{
    public partial class Form1 : Form{
        private StreamReader _stream;
        private SpeechSynthesizer _synth;

        public Form1()
        {
            InitializeComponent();
            _synth = new SpeechSynthesizer();
        }

        private void loadNotesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _stream = new StreamReader(openFileDialog1.FileName);
                notesLabel.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e){
            statusLabel.Text = "Waiting";
            currentLineLabel.Enabled = false;
            textBox1.Enabled = false;
            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.DarkGreen;
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (_stream != null){
                currentLineLabel.Enabled = true;
                textBox1.Enabled = true;
                
               
                statusLabel.Text = "Reading...";
                string line;
                while ((line = _stream.ReadLine()) != null){
                    textBox1.Text = line;
                    _synth.Speak(line);
                }
                statusLabel.Text = "Done";
            }else{
                statusLabel.Text = "No document loaded";
            }
            
            _stream.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}