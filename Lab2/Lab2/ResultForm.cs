using MetadataExtractor;
using MetadataExtractor.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ResultForm : Form
    {
        private class ScanResult
        {
            public string FileName { get; set; }
            public IReadOnlyList<MetadataExtractor.Directory> Metadata { get; set; }

            public ScanResult(string fileName, IReadOnlyList<MetadataExtractor.Directory> metadata)
            {
                FileName = fileName;
                Metadata = metadata;
            }
        }

        private FolderBrowserDialog folderBrowserDialog;

        public ResultForm()
        {
            InitializeComponent();

            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select folder to scan for images.";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void scanOtherButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentDirLabel.Text = folderBrowserDialog.SelectedPath;
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath,
                    "*", SearchOption.AllDirectories);

                informationView.Nodes.Clear();
                readingProgressBar.Maximum = files.Length;
                readingProgressBar.Value = 0;
                readingProgressBar.Visible = true;

                var tasks = new Task<ScanResult>[files.Length];
                for (int index = 0; index < files.Length; ++index)
                {
                    tasks[index] = Task.Factory.StartNew((Object file) =>
                    {
                        return scanFile((string) file);
                    },
                    files[index]);
                }

                Task.WhenAll(tasks).ContinueWith((finishedTasks) =>
                {
                    informationView.Invoke((MethodInvoker)delegate
                    {
                        fillInformationView(finishedTasks.Result);
                    });

                    readingProgressBar.Invoke((MethodInvoker)delegate
                    {
                        readingProgressBar.Visible = false;
                    });
                });
            }
        }

        private ScanResult scanFile(string fileName)
        {
            FileStream imageFile = File.OpenRead(fileName);
            ScanResult result = null;

            if (FileTypeDetector.DetectFileType(imageFile) != FileType.Unknown)
            {
                imageFile.Position = 0;
                result = new ScanResult(fileName, ImageMetadataReader.ReadMetadata(imageFile));
            }

            imageFile.Close();
            readingProgressBar.Invoke((MethodInvoker)delegate
            {
                readingProgressBar.Value = readingProgressBar.Value + 1;
            });

            return result;
        }

        private void fillInformationView(ScanResult[] results)
        {
            foreach (var result in results)
            {
                if (result == null)
                {
                    continue;
                }

                TreeNode coreNode = new TreeNode(result.FileName);
                foreach (var directory in result.Metadata)
                {
                    string directoryNodeName = directory.Name;
                    if (directory.HasError)
                    {
                        directoryNodeName += " [Warning: error detected!]";
                    }

                    TreeNode directoryNode = new TreeNode(directoryNodeName);
                    if (directory.HasError)
                    {
                        TreeNode errorsNode = new TreeNode("Errors");
                        foreach (var error in directory.Errors)
                        {
                            errorsNode.Nodes.Add(new TreeNode(error));
                        }

                        directoryNode.Nodes.Add(errorsNode);
                    }

                    foreach (var tag in directory.Tags)
                    {
                        directoryNode.Nodes.Add(new TreeNode(tag.Name + " = " + tag.Description));
                    }

                    coreNode.Nodes.Add(directoryNode);
                }

                informationView.Nodes.Add(coreNode);
            }
        }
    }
}
