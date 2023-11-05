using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MaFa.Winforms.SyncFileDate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            string src = txb_SourcePath.Text.Trim(), dst = txb_DestinationPath.Text.Trim();
            if (!Directory.Exists(src) || !Directory.Exists(dst))
            {
                // show dialog
                return;
            }

            string pattern = string.IsNullOrWhiteSpace(txb_Pattern.Text) ? "*" : txb_Pattern.Text.Trim();
            SearchOption searchOption = chb_Recursive.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            DisableControls();
            Thread thread = new Thread(() =>
            {
                string[] dstFiles = Directory.GetFiles(dst, pattern, searchOption);
                string[] srcFiles = Directory.GetFiles(src, pattern, searchOption);
                List<FileData> dstFileDatas = new List<FileData>(dstFiles.Select(y => new FileData(y)));
                List<FileData> srcFileDatas = new List<FileData>(srcFiles.Select(x => new FileData(x)));
                //DateTime lastWriteTime, creationTime, lastAccessTime;
                foreach (var fileData in dstFileDatas)
                {
                    try
                    {
                        var found = FileData.FindEqualivantFile(fileData, srcFileDatas);
                        if (found != null)
                        {
                            var fileInfo = new FileInfo(fileData.Path);
                            fileInfo.LastAccessTime = found.LastAccessTime;
                            fileInfo.CreationTime = found.CreationTime;
                            fileInfo.LastWriteTime = found.LastWriteTime;

                            txb_Result.InvokeIfRequired(x => x.AppendText($"{fileData.Path} processed.\r\n"));
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                DisableControls(false);
            });
            thread.Start();
        }

        private void DisableControls(bool disable = true)
        {
            List<Control> controls = new List<Control>();
            controls.Add(txb_SourcePath);
            controls.Add(txb_DestinationPath);
            controls.Add(txb_Pattern);
            controls.Add(chb_Recursive);
            controls.Add(btn_Sync);
            controls.Add(btn_BrowseSrc);
            controls.Add(btn_BrowseDst);
            controls.ForEach(x => x.InvokeIfRequired(y => y.Enabled = !disable));
            controls.Clear();
        }



        private void txb_SourcePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1 && !Directory.Exists(txb_SourcePath.Text = files[0]))
            {
                txb_SourcePath.Text = string.Empty;
            }
        }

        private void txb_SourcePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void txb_SourcePath_DragOver(object sender, DragEventArgs e)
        {

        }

        private void txb_DestinationPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1 && !Directory.Exists(txb_DestinationPath.Text = files[0]))
            {
                txb_DestinationPath.Text = string.Empty;
            }
        }

        private void txb_DestinationPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void txb_DestinationPath_DragOver(object sender, DragEventArgs e)
        {

        }

        private void btn_BrowseSrc_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openfolderdlg = new CommonOpenFileDialog();
            openfolderdlg.IsFolderPicker = true;
            openfolderdlg.RestoreDirectory = true;

            if (openfolderdlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txb_SourcePath.Text = openfolderdlg.FileName;
            }
        }

        private void btn_BrowseDst_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openfolderdlg = new CommonOpenFileDialog();
            openfolderdlg.IsFolderPicker = true;
            openfolderdlg.RestoreDirectory = true;

            if (openfolderdlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txb_DestinationPath.Text = openfolderdlg.FileName;
            }
        }
    }

    public class FileData
    {
        private Version _version;
        private string _name;
        private string _fullName;

        public FileData()
        {
        }

        public FileData(string path)
        {
            Path = path;
            FileInfo fileInfo = new FileInfo(path);
            if (!(IsAssembly = IsValidAssembly(path, ref _name, ref _version, ref _fullName)))
            {
                _name = fileInfo.Name;
            }

            LastAccessTime = fileInfo.LastAccessTime;
            CreationTime = fileInfo.CreationTime;
            LastWriteTime = fileInfo.LastWriteTime;
        }

        public string Path { get; set; }
        public bool IsAssembly { get; set; }
        public Version Version
        {
            get { return _version; }
            set { _version = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public DateTime LastAccessTime { get; set; } = DateTime.MinValue;
        public DateTime CreationTime { get; set; } = DateTime.MinValue;
        public DateTime LastWriteTime { get; set; } = DateTime.MinValue;

        public static bool IsValidAssembly(string path, ref string name, ref Version version, ref string fullName)
        {
            try
            {
                var assembly = AssemblyName.GetAssemblyName(path);
                name = assembly.Name;
                version = assembly.Version;
                fullName = assembly.FullName;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static FileData FindEqualivantFile(FileData dstFiledata, IEnumerable<FileData> srcFileDatas)
        {
            foreach (var fileData in srcFileDatas)
            {
                if (dstFiledata.Name.Equals(fileData.Name, StringComparison.OrdinalIgnoreCase))
                {
                    if (dstFiledata.IsAssembly && fileData.IsAssembly &&
                        dstFiledata.Version.Equals(fileData.Version) &&
                        dstFiledata.FullName.Equals(fileData.FullName, StringComparison.OrdinalIgnoreCase))
                    {
                        return fileData;
                    }
                }
            }
            return null;
        }
    }

    public static class ControlHelper
    {
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}
