using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileRemover
{
    public partial class frmMain : Form
    {
        Regex re = new Regex(@"[^0-9]");
        List<string> extensions = new List<string>();
        List<string> keywords;
        long expectedSize = 0;
        int found = 0;
        int deleted = 0;
        StreamReader sr;
        long fileSize;
        bool started = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void ChkSize_CheckedChanged(object sender, EventArgs e)
        {
            txtSize.Enabled = chkSize.Checked;
            if (chkSize.Checked) txtSize.Text = "0";
        }

        private void ChkInclude_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Enabled = chkInclude.Checked;

        }
        private void ChkExtension_CheckedChanged(object sender, EventArgs e)
        {
            txtExtension.Enabled = chkExtension.Checked;
        }

        private void TxtSource_LostFocus(object sender, System.EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text)) txtSource.Text = "";
            btnStart.Enabled = txtSource.Text.Length > 0;
        }

        private void BtnBrowseSource_Click(object sender, EventArgs e)
        {
            if (ofdSource.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = ofdSource.SelectedPath;
                if (!Directory.Exists(txtSource.Text)) txtSource.Text = "";
            }
            else
            {
                txtSource.Text = "";
            }
            btnStart.Enabled = txtSource.Text.Length > 0;
        }

        private void TxtSize_TextChanged(object sender, EventArgs e)
        {
            txtSize.Text = re.Replace(txtSize.Text, "");
            if (txtSize.Text.Length == 0) txtSize.Text = "0";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                started = true;
                btnStart.Text = "Stop";
                expectedSize = chkSize.Checked && txtSize.Text.Length > 0 ? Convert.ToInt32(txtSize.Text) : 0;
                if (chkInclude.Checked) keywords = txtText.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                if (chkExtension.Checked) extensions.AddRange(txtExtension.Text.Replace(" ", "").Split(','));
                ProcessFolder(txtSource.Text);
                string[] files = Directory.GetFiles(txtSource.Text);
                string[] folders = Directory.GetDirectories(txtSource.Text);
                if (files.Length == 0 && folders.Length == 0) Directory.Delete(txtSource.Text);
                started = false;
                btnStart.Text = "Start";
            }
            else
            {
                started = false;
                btnStart.Text = "Start";
            }
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text)) txtSource.Text = "";
            btnStart.Enabled = txtSource.Text.Length > 0 && txtSource.Text.Length > 0;
        }

        private void ProcessFolder(String folder)
        {
            if (!started) return;
            string[] files = Directory.GetFiles(folder);
            for (int i = 0; i < files.Length; i++) ProcessFile(files[i]);
            files = Directory.GetFiles(folder);
            string[] folders = Directory.GetDirectories(folder);
            if (files.Length == 0 && folders.Length == 0) Directory.Delete(folder);
            if (!chkSubfolders.Checked) return;
            for (int i = 0; i < folders.Length; i++)
            {
                ProcessFolder(folders[i]);
            }
        }
        private void ProcessFile(String file)
        {
            if (!started) return;
            found++;
            bool delete = false;
            if (extensions.Count == 0) delete = true;
            else
            {
                if (extensions.Contains(Path.GetExtension(file).Substring(1))) delete = true;
            }
            if (chkSize.Checked)
            {
                fileSize = new FileInfo(file).Length;
                if (fileSize > expectedSize) delete = true;
            }
            if (chkInclude.Checked)
            {
                sr = new StreamReader(file);
                String text = sr.ReadToEnd();
                sr.Close();
                foreach (string keyword in keywords)
                {
                    if (text.Contains(keyword))
                    {
                        delete = true;
                        break;
                    }
                }
            }
            if (delete)
            {
                deleted++;
                File.Delete(file);
            }
            lblStatus.Text = found.ToString() + " files found, " + deleted.ToString() + " files deleted";
            Application.DoEvents();
        }
    }
}
