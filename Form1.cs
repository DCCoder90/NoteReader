using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace NoteReader
{
    public partial class Form1 : Form{
        private StreamReader _stream;
        private SpeechSynthesizer _synth;
        


        public Form1()
        {
            InitializeComponent();
            _synth = new SpeechSynthesizer();
            readButton.Enabled = false;
        }

        private void loadNotesButton_Click(object sender, EventArgs e){
            statusLabel.Text = "Loading notes...";
            LoadNotes();
        }

        private void Form1_Load(object sender, EventArgs e){
            statusLabel.Text = "Waiting";
            currentLineLabel.Enabled = false;
            textBox1.Enabled = false;
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
                _stream.Close();
                readButton.Enabled = false;
            }else{
                statusLabel.Text = "No document loaded";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool LoadNotes()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _stream =new StreamReader(openFileDialog1.FileName);
                notesLabel.Text = openFileDialog1.FileName;
                statusLabel.Text = "Loaded notes";
                readButton.Enabled = true;
                return true;
            }
            statusLabel.Text = "Couldn't load notes";
            return false;
        }
    }
}