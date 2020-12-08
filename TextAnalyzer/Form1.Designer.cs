namespace TextAnalyzer
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
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSeparators = new System.Windows.Forms.Button();
            this.btnExceptions = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(430, 408);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(112, 42);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnExceptions);
            this.panel1.Controls.Add(this.btnSeparators);
            this.panel1.Controls.Add(this.lstNames);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.lstWords);
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 452);
            this.panel1.TabIndex = 1;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 16;
            this.lstNames.Location = new System.Drawing.Point(220, 4);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(204, 308);
            this.lstNames.TabIndex = 4;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(430, 5);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(379, 307);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(315, 408);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(109, 41);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Load a file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 16;
            this.lstWords.Location = new System.Drawing.Point(3, 3);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(210, 308);
            this.lstWords.TabIndex = 1;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Text files|*.txt|All files|*.*";
            this.dlgOpenFile.Title = "Select your text file";
            // 
            // btnSeparators
            // 
            this.btnSeparators.Location = new System.Drawing.Point(3, 408);
            this.btnSeparators.Name = "btnSeparators";
            this.btnSeparators.Size = new System.Drawing.Size(126, 42);
            this.btnSeparators.TabIndex = 5;
            this.btnSeparators.Text = "Load separators";
            this.btnSeparators.UseVisualStyleBackColor = true;
            this.btnSeparators.Click += new System.EventHandler(this.btnSeparators_Click);
            // 
            // btnExceptions
            // 
            this.btnExceptions.Location = new System.Drawing.Point(4, 362);
            this.btnExceptions.Name = "btnExceptions";
            this.btnExceptions.Size = new System.Drawing.Size(125, 40);
            this.btnExceptions.TabIndex = 6;
            this.btnExceptions.Text = "Load exceptions";
            this.btnExceptions.UseVisualStyleBackColor = true;
            this.btnExceptions.Click += new System.EventHandler(this.btnExceptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 476);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Text Analyzer by Akmal Djumakhodjaev";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnSeparators;
        private System.Windows.Forms.Button btnExceptions;
    }
}

