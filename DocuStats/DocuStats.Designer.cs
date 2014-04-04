namespace DocuStats
{
    partial class DocuStats
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paragLabel = new System.Windows.Forms.Label();
            this.linesLabel = new System.Windows.Forms.Label();
            this.wordsLabel = new System.Windows.Forms.Label();
            this.charsNoLabel = new System.Windows.Forms.Label();
            this.charsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(397, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(35, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Characters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Characters (no spaces)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lines";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Paragraphs";
            // 
            // paragLabel
            // 
            this.paragLabel.AutoSize = true;
            this.paragLabel.Location = new System.Drawing.Point(241, 173);
            this.paragLabel.Name = "paragLabel";
            this.paragLabel.Size = new System.Drawing.Size(13, 13);
            this.paragLabel.TabIndex = 11;
            this.paragLabel.Text = "0";
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Location = new System.Drawing.Point(241, 144);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(13, 13);
            this.linesLabel.TabIndex = 10;
            this.linesLabel.Text = "0";
            // 
            // wordsLabel
            // 
            this.wordsLabel.AutoSize = true;
            this.wordsLabel.Location = new System.Drawing.Point(241, 115);
            this.wordsLabel.Name = "wordsLabel";
            this.wordsLabel.Size = new System.Drawing.Size(13, 13);
            this.wordsLabel.TabIndex = 9;
            this.wordsLabel.Text = "0";
            // 
            // charsNoLabel
            // 
            this.charsNoLabel.AutoSize = true;
            this.charsNoLabel.Location = new System.Drawing.Point(241, 86);
            this.charsNoLabel.Name = "charsNoLabel";
            this.charsNoLabel.Size = new System.Drawing.Size(13, 13);
            this.charsNoLabel.TabIndex = 8;
            this.charsNoLabel.Text = "0";
            // 
            // charsLabel
            // 
            this.charsLabel.AutoSize = true;
            this.charsLabel.Location = new System.Drawing.Point(241, 57);
            this.charsLabel.Name = "charsLabel";
            this.charsLabel.Size = new System.Drawing.Size(13, 13);
            this.charsLabel.TabIndex = 7;
            this.charsLabel.Text = "0";
            // 
            // DocuStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 206);
            this.Controls.Add(this.paragLabel);
            this.Controls.Add(this.linesLabel);
            this.Controls.Add(this.wordsLabel);
            this.Controls.Add(this.charsNoLabel);
            this.Controls.Add(this.charsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.Name = "DocuStats";
            this.Text = "DocuStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label paragLabel;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.Label wordsLabel;
        private System.Windows.Forms.Label charsNoLabel;
        private System.Windows.Forms.Label charsLabel;
    }
}

