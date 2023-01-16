namespace Sign
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogSigntool = new System.Windows.Forms.OpenFileDialog();
            this.ChooseSigntool = new System.Windows.Forms.Button();
            this.textBoxSigntool = new System.Windows.Forms.TextBox();
            this.labelSigntool = new System.Windows.Forms.Label();
            this.ChooseCer = new System.Windows.Forms.Button();
            this.textBoxCer = new System.Windows.Forms.TextBox();
            this.labelSelectCer = new System.Windows.Forms.Label();
            this.openFileDialogCer = new System.Windows.Forms.OpenFileDialog();
            this.labelPathFiles = new System.Windows.Forms.Label();
            this.buttonPathFiles = new System.Windows.Forms.Button();
            this.textBoxPathFiles = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFilesInput = new System.Windows.Forms.TextBox();
            this.labelEnterFiles1 = new System.Windows.Forms.Label();
            this.labelEnterFiles2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelEnterFiles3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogSigntool
            // 
            this.openFileDialogSigntool.DefaultExt = "exe";
            this.openFileDialogSigntool.FileName = "Signtool.exe";
            this.openFileDialogSigntool.Filter = "Executable file (*.exe)|*.exe|All files (*.*)|*.*";
            this.openFileDialogSigntool.InitialDirectory = "C:\\Program Files (x86)\\Windows Kits\\10\\bin\\10.0.22621.0\\x86";
            this.openFileDialogSigntool.Tag = "exe";
            // 
            // ChooseSigntool
            // 
            this.ChooseSigntool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseSigntool.Location = new System.Drawing.Point(290, 54);
            this.ChooseSigntool.Name = "ChooseSigntool";
            this.ChooseSigntool.Size = new System.Drawing.Size(33, 23);
            this.ChooseSigntool.TabIndex = 1;
            this.ChooseSigntool.Text = "...";
            this.ChooseSigntool.UseVisualStyleBackColor = true;
            this.ChooseSigntool.Click += new System.EventHandler(this.ChooseSigntool_Click);
            // 
            // textBoxSigntool
            // 
            this.textBoxSigntool.Enabled = false;
            this.textBoxSigntool.Location = new System.Drawing.Point(15, 54);
            this.textBoxSigntool.Name = "textBoxSigntool";
            this.textBoxSigntool.Size = new System.Drawing.Size(268, 23);
            this.textBoxSigntool.TabIndex = 2;
            // 
            // labelSigntool
            // 
            this.labelSigntool.AutoSize = true;
            this.labelSigntool.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSigntool.Location = new System.Drawing.Point(12, 20);
            this.labelSigntool.Name = "labelSigntool";
            this.labelSigntool.Size = new System.Drawing.Size(317, 20);
            this.labelSigntool.TabIndex = 3;
            this.labelSigntool.Text = "Find and select the file signtool.exe on your PC";
            // 
            // ChooseCer
            // 
            this.ChooseCer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseCer.Location = new System.Drawing.Point(290, 133);
            this.ChooseCer.Name = "ChooseCer";
            this.ChooseCer.Size = new System.Drawing.Size(33, 23);
            this.ChooseCer.TabIndex = 1;
            this.ChooseCer.Text = "...";
            this.ChooseCer.UseVisualStyleBackColor = true;
            this.ChooseCer.Visible = false;
            this.ChooseCer.Click += new System.EventHandler(this.ChooseCer_Click);
            // 
            // textBoxCer
            // 
            this.textBoxCer.Enabled = false;
            this.textBoxCer.Location = new System.Drawing.Point(15, 133);
            this.textBoxCer.Name = "textBoxCer";
            this.textBoxCer.Size = new System.Drawing.Size(268, 23);
            this.textBoxCer.TabIndex = 2;
            this.textBoxCer.Visible = false;
            this.textBoxCer.TextChanged += new System.EventHandler(this.textBoxCer_TextChanged);
            // 
            // labelSelectCer
            // 
            this.labelSelectCer.AutoSize = true;
            this.labelSelectCer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectCer.Location = new System.Drawing.Point(12, 99);
            this.labelSelectCer.Name = "labelSelectCer";
            this.labelSelectCer.Size = new System.Drawing.Size(169, 20);
            this.labelSelectCer.TabIndex = 3;
            this.labelSelectCer.Text = "Select the certificate file";
            this.labelSelectCer.Visible = false;
            // 
            // openFileDialogCer
            // 
            this.openFileDialogCer.DefaultExt = "exe";
            this.openFileDialogCer.Filter = "Certificate file (*.cer)|*.cer|Pfx file (*.pfx)|*.pfx|All files (*.*)|*.*";
            this.openFileDialogCer.InitialDirectory = "C:\\";
            this.openFileDialogCer.Tag = "exe";
            // 
            // labelPathFiles
            // 
            this.labelPathFiles.AutoSize = true;
            this.labelPathFiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPathFiles.Location = new System.Drawing.Point(15, 175);
            this.labelPathFiles.Name = "labelPathFiles";
            this.labelPathFiles.Size = new System.Drawing.Size(262, 20);
            this.labelPathFiles.TabIndex = 4;
            this.labelPathFiles.Text = "Select the folder in which we will work";
            this.labelPathFiles.Visible = false;
            this.labelPathFiles.Click += new System.EventHandler(this.labelPathFiles_Click);
            // 
            // buttonPathFiles
            // 
            this.buttonPathFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPathFiles.Location = new System.Drawing.Point(290, 209);
            this.buttonPathFiles.Name = "buttonPathFiles";
            this.buttonPathFiles.Size = new System.Drawing.Size(33, 23);
            this.buttonPathFiles.TabIndex = 1;
            this.buttonPathFiles.Text = "...";
            this.buttonPathFiles.UseVisualStyleBackColor = true;
            this.buttonPathFiles.Visible = false;
            this.buttonPathFiles.Click += new System.EventHandler(this.buttonPathFiles_Click);
            // 
            // textBoxPathFiles
            // 
            this.textBoxPathFiles.Enabled = false;
            this.textBoxPathFiles.Location = new System.Drawing.Point(15, 209);
            this.textBoxPathFiles.Name = "textBoxPathFiles";
            this.textBoxPathFiles.Size = new System.Drawing.Size(268, 23);
            this.textBoxPathFiles.TabIndex = 2;
            this.textBoxPathFiles.Visible = false;
            this.textBoxPathFiles.TextChanged += new System.EventHandler(this.textBoxPathFiles_TextChanged);
            // 
            // folderBrowserDialogFiles
            // 
            this.folderBrowserDialogFiles.InitialDirectory = "C:\\";
            // 
            // textBoxFilesInput
            // 
            this.textBoxFilesInput.Location = new System.Drawing.Point(15, 295);
            this.textBoxFilesInput.Multiline = true;
            this.textBoxFilesInput.Name = "textBoxFilesInput";
            this.textBoxFilesInput.Size = new System.Drawing.Size(308, 80);
            this.textBoxFilesInput.TabIndex = 5;
            this.textBoxFilesInput.Visible = false;
            this.textBoxFilesInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEnterFiles1
            // 
            this.labelEnterFiles1.AutoSize = true;
            this.labelEnterFiles1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterFiles1.Location = new System.Drawing.Point(15, 244);
            this.labelEnterFiles1.Name = "labelEnterFiles1";
            this.labelEnterFiles1.Size = new System.Drawing.Size(305, 20);
            this.labelEnterFiles1.TabIndex = 4;
            this.labelEnterFiles1.Text = "Enter the full file names separated by a enter";
            this.labelEnterFiles1.Visible = false;
            this.labelEnterFiles1.Click += new System.EventHandler(this.labelEnterFiles1_Click);
            // 
            // labelEnterFiles2
            // 
            this.labelEnterFiles2.AutoSize = true;
            this.labelEnterFiles2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterFiles2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEnterFiles2.Location = new System.Drawing.Point(14, 266);
            this.labelEnterFiles2.Name = "labelEnterFiles2";
            this.labelEnterFiles2.Size = new System.Drawing.Size(269, 17);
            this.labelEnterFiles2.TabIndex = 6;
            this.labelEnterFiles2.Text = "(Can be copied from the sigverif application)";
            this.labelEnterFiles2.Visible = false;
            this.labelEnterFiles2.Click += new System.EventHandler(this.labelEnterFiles2_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(248, 382);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 27);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelEnterFiles3
            // 
            this.labelEnterFiles3.AutoSize = true;
            this.labelEnterFiles3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterFiles3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEnterFiles3.Location = new System.Drawing.Point(15, 390);
            this.labelEnterFiles3.Name = "labelEnterFiles3";
            this.labelEnterFiles3.Size = new System.Drawing.Size(186, 15);
            this.labelEnterFiles3.TabIndex = 8;
            this.labelEnterFiles3.Text = "(You can change the window size)";
            this.labelEnterFiles3.Visible = false;
            this.labelEnterFiles3.Click += new System.EventHandler(this.labelEnterFiles3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 416);
            this.Controls.Add(this.labelEnterFiles3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelEnterFiles2);
            this.Controls.Add(this.textBoxFilesInput);
            this.Controls.Add(this.labelEnterFiles1);
            this.Controls.Add(this.labelPathFiles);
            this.Controls.Add(this.labelSelectCer);
            this.Controls.Add(this.textBoxPathFiles);
            this.Controls.Add(this.textBoxCer);
            this.Controls.Add(this.buttonPathFiles);
            this.Controls.Add(this.labelSigntool);
            this.Controls.Add(this.ChooseCer);
            this.Controls.Add(this.textBoxSigntool);
            this.Controls.Add(this.ChooseSigntool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialogSigntool;
        private Button ChooseSigntool;
        private TextBox textBoxSigntool;
        private Label labelSigntool;
        private Button ChooseCer;
        private TextBox textBoxCer;
        private Label labelSelectCer;
        private OpenFileDialog openFileDialogCer;
        private Label labelPathFiles;
        private Button buttonPathFiles;
        private TextBox textBoxPathFiles;
        private FolderBrowserDialog folderBrowserDialogFiles;
        private TextBox textBoxFilesInput;
        private Label labelEnterFiles1;
        private Label labelEnterFiles2;
        private Button buttonStart;
        private Label labelEnterFiles3;
    }
}