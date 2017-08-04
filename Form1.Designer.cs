namespace NoteReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readButton = new System.Windows.Forms.Button();
            this.constStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.loadNotesButton = new System.Windows.Forms.Button();
            this.currentLineLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 12);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read Notes";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // constStatusLabel
            // 
            this.constStatusLabel.AutoSize = true;
            this.constStatusLabel.Location = new System.Drawing.Point(17, 67);
            this.constStatusLabel.Name = "constStatusLabel";
            this.constStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.constStatusLabel.TabIndex = 1;
            this.constStatusLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(63, 67);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "label2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(57, 44);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(0, 13);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Text = "TEST";
            // 
            // loadNotesButton
            // 
            this.loadNotesButton.Location = new System.Drawing.Point(137, 12);
            this.loadNotesButton.Name = "loadNotesButton";
            this.loadNotesButton.Size = new System.Drawing.Size(75, 23);
            this.loadNotesButton.TabIndex = 5;
            this.loadNotesButton.Text = "Load Notes";
            this.loadNotesButton.UseVisualStyleBackColor = true;
            this.loadNotesButton.Click += new System.EventHandler(this.loadNotesButton_Click);
            // 
            // currentLineLabel
            // 
            this.currentLineLabel.AutoSize = true;
            this.currentLineLabel.Location = new System.Drawing.Point(17, 96);
            this.currentLineLabel.Name = "currentLineLabel";
            this.currentLineLabel.Size = new System.Drawing.Size(67, 13);
            this.currentLineLabel.TabIndex = 6;
            this.currentLineLabel.Text = "Current Line:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 52);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 174);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currentLineLabel);
            this.Controls.Add(this.loadNotesButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.constStatusLabel);
            this.Controls.Add(this.readButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Note Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label constStatusLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button loadNotesButton;
        private System.Windows.Forms.Label currentLineLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

