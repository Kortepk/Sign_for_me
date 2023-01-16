using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sign
{
    public partial class Form1 : Form
    {
        string FilePathSigntool = "", // Path
               FilePathCer = "", // Path
               FilePathFiles = ""; // Path

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process(); 
            process.StartInfo.FileName = "cmd.exe"; // Lines to configure
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = @"C:\";
            process.StartInfo.Verb = "runas"; // On behalf of the administrator

            process.Start();
            /*
            process.StandardInput.WriteLine("cd C:\\Program Files (x86)\\Windows Kits\\10\\bin\\10.0.22621.0\\x64");
            process.StandardInput.Flush();
            Thread.Sleep(2000);
            process.StandardInput.WriteLine("signtool sign /tr http://timestamp.digicert.com /fd SHA256 /td SHA256 /v /f \"C:\\DrvCert\\myDrivers.pfx\" /p P@ss0wrd \"c:\\windows\\system32\\nvapi64.dll\"");
            Thread.Sleep(4000);
            process.StandardInput.Close();*/
        }

        private void ChooseSigntool_Click(object sender, EventArgs e)
        {
            if(openFileDialogSigntool.ShowDialog() == DialogResult.Cancel)
                return;

            FilePathSigntool = openFileDialogSigntool.FileName;

            textBoxSigntool.Text = FilePathSigntool;

            labelSelectCer.Visible = true;
            textBoxCer.Visible = true;
            ChooseCer.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Width >= 355)
            {
                int change = this.Width - 355;
                textBoxSigntool.Size = new Size(268 + change, 23);
                textBoxCer.Size = new Size(268 + change, 23);
                textBoxPathFiles.Size = new Size(268 + change, 23);
                textBoxFilesInput.Size = new Size(308 + change, textBoxFilesInput.Size.Height);
                ChooseSigntool.Location = new Point(290 + change, 54);
                ChooseCer.Location = new Point(290 + change, 133);
                buttonPathFiles.Location = new Point(290 + change, 209);
                buttonStart.Location = new Point(248 + change, 382);
            }
            else
            {
                textBoxSigntool.Size = new Size(268, 23);
                textBoxCer.Size = new Size(268, 23);
                textBoxPathFiles.Size = new Size(268, 23);
                textBoxFilesInput.Size = new Size(308, textBoxFilesInput.Size.Height);
                ChooseSigntool.Location = new Point(290, 54);
                ChooseCer.Location = new Point(290, 133);
                buttonPathFiles.Location = new Point(290, 209);
                buttonStart.Location = new Point(248, 382);
            }

            if (this.Height >= 455)
            {
                int change = this.Height - 455;
                textBoxFilesInput.Size = new Size(textBoxFilesInput.Size.Width, 80 + change);
                buttonStart.Location = new Point(buttonStart.Location.X, 382 + change);
                labelEnterFiles3.Location = new Point(15, 390 + change);
            }
            else { 
                textBoxFilesInput.Size = new Size(textBoxFilesInput.Size.Width, 80);
                buttonStart.Location = new Point(buttonStart.Location.X, 382);
                labelEnterFiles3.Location = new Point(15, 390);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] words = textBoxFilesInput.Text.Split(new char[] { '\n' });

            string command = "signtool sign /tr http://timestamp.digicert.com /fd SHA256 /td SHA256 /v /f ";
            command += "\"" + FilePathCer + "\" /p P@ss0wrd ";

            string s_temp;
            foreach (string s in words)
            {
                s_temp = s + " ";
                s_temp = s.Substring(0, s_temp.IndexOf(' '));
                command += "\"" + FilePathFiles + "\\" + s_temp + "\" ";
            }

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe"; // Lines to configure
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = @"C:\";
            process.StartInfo.Verb = "runas"; // On behalf of the administrator

            process.Start();
            process.StandardInput.WriteLine("cd "+ FilePathSigntool.Substring(0, FilePathSigntool.LastIndexOf('\\')));
            process.StandardInput.WriteLine(command);
            Thread.Sleep(10000);
            process.StandardInput.Close();
        }

        private void labelEnterFiles2_Click(object sender, EventArgs e)
        {

        }

        private void labelEnterFiles1_Click(object sender, EventArgs e)
        {

        }

        private void labelPathFiles_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPathFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCer_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEnterFiles3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseCer_Click(object sender, EventArgs e)
        {
            if (openFileDialogCer.ShowDialog() == DialogResult.Cancel)
                return;
            FilePathCer = openFileDialogCer.FileName;
            textBoxCer.Text = FilePathCer;

            labelPathFiles.Visible = true;
            textBoxPathFiles.Visible = true;
            buttonPathFiles.Visible = true;
        }

        private void buttonPathFiles_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogFiles.ShowDialog() == DialogResult.Cancel)
                return;

            FilePathFiles = folderBrowserDialogFiles.SelectedPath;

            textBoxPathFiles.Text = FilePathFiles;

            labelEnterFiles1.Visible = true;
            labelEnterFiles2.Visible = true;
            textBoxFilesInput.Visible = true;
            labelEnterFiles3.Visible = true;
        }
    }
}