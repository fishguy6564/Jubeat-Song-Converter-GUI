using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jubeat_Song_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string AddQuotesIfRequired(string path)
        {
            return !string.IsNullOrWhiteSpace(path) ?
                path.Contains(" ") && (!path.StartsWith("\"") && !path.EndsWith("\"")) ?
                    "\"" + path + "\"" : path :
                    string.Empty;
        }
        public string buildIFS()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();

                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.WorkingDirectory = path;
                p.Start();
                p.StandardInput.WriteLine("cd " + AddQuotesIfRequired(path + "\\bin\\"));
                p.StandardInput.Flush();
                p.StandardInput.WriteLine("ifstools " + AddQuotesIfRequired(path + "\\tmp") + " -o " + AddQuotesIfRequired(path));
                p.StandardInput.Flush();
                p.StandardInput.Close();
                string str = p.StandardOutput.ReadToEnd();
                return str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching process", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string sendCommand(string fileinname, string fileoutname, string command)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();

                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.WorkingDirectory = path;
                p.Start();
                p.StandardInput.WriteLine("cd " + AddQuotesIfRequired(path + "\\bin\\"));
                p.StandardInput.Flush();
                p.StandardInput.WriteLine(command + " " + AddQuotesIfRequired(fileinname) + " " + AddQuotesIfRequired(path + "\\tmp\\" + fileoutname));
                p.StandardInput.Flush();
                p.StandardInput.Close();
                string str = p.StandardOutput.ReadToEnd();
                return str;
            }catch(Exception ex)
            {
                MessageBox.Show("Error launching process", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        static void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            Console.WriteLine(e.Data);
        }

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            Console.WriteLine(e.Data);
        }

        private void OpenSong_Click(object sender, EventArgs e)
        {
            if(openSongDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bgmDirectory.Text = openSongDialog.FileName;
            }
        }

        private void OpenPreview_Click(object sender, EventArgs e)
        {
            if (openSongDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                previewDirectory.Text = openSongDialog.FileName;
            }
        }

        private void OpenBasic_Click(object sender, EventArgs e)
        {
            if (openChartDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                basicDirectory.Text = openChartDialog.FileName;
            }
        }

        private void OpenAdvance_Click(object sender, EventArgs e)
        {
            if (openChartDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                advancedDirectory.Text = openChartDialog.FileName;
            }
        }

        private void OpenExtreme_Click(object sender, EventArgs e)
        {
            if (openChartDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                extremeDirectory.Text = openChartDialog.FileName;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!sendCommand(bgmDirectory.Text, "bgm.bin", "jubeatencoder").Contains("Done!"))
            {
                MessageBox.Show("Error Creating bgm.bin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!sendCommand(previewDirectory.Text, "idx.bin", "jubeatencoder").Contains("Done!"))
            {
                MessageBox.Show("Error Creating idx.bin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!sendCommand(basicDirectory.Text, "bsc.eve", "memoneveconverter").Contains("Done!"))
            {
                MessageBox.Show("Error Creating bsc.eve", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!sendCommand(advancedDirectory.Text, "adv.eve", "memoneveconverter").Contains("Done!"))
            {
                MessageBox.Show("Error Creating adv.eve", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!sendCommand(extremeDirectory.Text, "ext.eve", "memoneveconverter").Contains("Done!"))
            {
                MessageBox.Show("Error Creating ext.eve", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buildIFS();

            byte[] ifsFile;

            using (FileStream file = new FileStream(Directory.GetCurrentDirectory() + "\\tmp.ifs", FileMode.Open, FileAccess.Read))
            {
                ifsFile = new byte[file.Length];
                file.Read(ifsFile, 0, (int)file.Length);
            }
            File.Delete(Directory.GetCurrentDirectory() + "\\tmp.ifs");

            if(saveIFSFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string saveDirectory = saveIFSFileDialog.FileName;

                using(FileStream file = new FileStream(saveDirectory, FileMode.Create, FileAccess.Write))
                {
                    file.Write(ifsFile, 0, ifsFile.Length);
                }
            }
        }
    }
}
