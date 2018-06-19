using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class MainForm : Form
    {
        string FilePath = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void rtxt_work_TextChanged(object sender, EventArgs e)
        {
            Page_Work.Text = "Work *";
            rtxt_md5.Text = Encrypter.EncryptString(rtxt_work.Text, Set.md5key);
        }

        #region ShowForm

        private void SetToolStripMenuItem_Click(object sender, EventArgs e) { Set s = new Set(); s.ShowDialog(); }

        #endregion

        #region Open SaveAs Save

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = FilePath = openFileDialog.FileName;
                StreamReader sr = new StreamReader(FileName, Set.stringEncoding);
                rtxt_work.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = FilePath = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(FileName, true, Set.stringEncoding);
                sw.WriteLine(rtxt_work.Text);
                sw.Close();
                Page_Work.Text = "Work";
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                saveAsToolStripMenuItem.PerformClick();
                return;
            }
            StreamWriter sw = new StreamWriter(FilePath, true, Set.stringEncoding);
            sw.WriteLine(rtxt_work.Text);
            sw.Close();
            Page_Work.Text = "Work";
        }

        #endregion

        #region Other

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) { Environment.Exit(0); }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) { toolStrip.Visible = toolBarToolStripMenuItem.Checked; }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) { statusStrip.Visible = statusBarToolStripMenuItem.Checked; }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) { Environment.Exit(0); }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) { rtxt_work.Undo(); }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxt_work.Text))
                rtxt_work.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxt_work.Text))
                rtxt_work.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxt_work.Text))
                rtxt_work.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxt_work.Text))
                rtxt_work.SelectAll();
        }

        #endregion

        #region MD5

        private void copyStripButton1_Click(object sender, EventArgs e) { rtxt_md5.Copy(); }

        #endregion

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_work.Redo();
        }
    }
}
