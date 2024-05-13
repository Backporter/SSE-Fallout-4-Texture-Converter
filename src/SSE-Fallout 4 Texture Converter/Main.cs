using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SSE_Fallout_4_Texture_Converter.Logic;
using SSE_Fallout_4_Texture_Converter.Properties;

namespace SSE_Fallout_4_Texture_Converter
{
	public partial class Main : Form
	{
        //
        public static List<string> filePaths = new List<string>();

        //
        public string config = "SSE-Fallout 4 Texture Converter.exe.config";

        //
        private void UIUpdater(object sender, DoWorkEventArgs e)
        {
            while (!((BackgroundWorker)sender).CancellationPending)
            {
                lock(GNF.ProcessedLock)
                {
                    UpdateProgress(GNF.Processed);

                    if (GNF.Processed == filePaths.Count)
                    {
                        Finished();
                        return;
                    }
                }
            }

            e.Cancel = true;
        }

        public void Finished()
        {
            base.Invoke(new Action(delegate ()
            {
                MessageBox.Show("Your Textures are converted!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                convertlb.Text = "Finished";
                filePaths.Clear();
                lboxFiles.Items.Clear();
                progressBar1.Value = 0;
                GNF.Processed = 0;
                Threading.Global.UIWorker.CancelAsync();
                btClear.Enabled = true;
                btadd.Enabled = true;
                btadddir.Enabled = true;
            }));
        }

        public void UpdateProgress(int TotalProcessed)
        {
            base.Invoke(new Action(delegate()
            {
                convertlb.Text = $"{filePaths.Count - TotalProcessed} To Be Converted";
                progressBar1.Value = TotalProcessed;
            }));
        }

        public static List<List<string>> SplitList(List<string> list, int totalParts)
        {
            int size = (int)Math.Ceiling(list.Count / (double)totalParts);
            var splitList = new List<List<string>>();

            for (int i = 0; i < totalParts; i++)
            {
                var array = list.Skip(size * i).Take(size).ToList();
                if (array.Count == 0)
                {
                    continue;
                }

                splitList.Add(array);
            }

            return splitList;
        }

        //
        public Main()
		{
            //
            Settings.Global = new Settings();
            Credits.Global = new Credits();
            Threading.Global = new Threading();

            //
            InitializeComponent();
		}

        private void formatcb_TextChanged(object sender, EventArgs e)
        {
            GNF.Format = ((ComboBox)sender).Text;
        }

        private void Main_Load(object sender, EventArgs e)
		{
            //
            if (!File.Exists(config))
            {
                File.WriteAllText(config, Resources.config);
            }

            if (Properties.Settings.Default.warned == "false")
			{
				MessageBox.Show("if any other required tools are missing this will not work right\n\nDue to legail reasons i can't include the required tools you will need to find them yourself\n\nDo not delete the config file! if you do you will need to redownlioad the tool from github or re-extract it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Properties.Settings.Default.warned = "true";
                Properties.Settings.Default.Save();
			}

            if (!File.Exists(SCEE.GetExecutablePath("orbis-image2gnf.exe")))
            {
				MessageBox.Show("orbis-image2gnf.exe is missing please put it in the data folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}

			if (!File.Exists(SCEE.GetExecutablePath("libSceGnm.dll")))
            {
				MessageBox.Show("libSceGnm.dll is missing please put it in the data folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}

			if (!File.Exists(SCEE.GetExecutablePath("libSceGpuAddress.dll")))
            {
				MessageBox.Show("libSceGpuAddress.dll is missing please put it in the data folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}

			if (!File.Exists(SCEE.GetExecutablePath("libSceTextureTool.dll")))
			{
				MessageBox.Show("libSceTextureTool.dll is missing please put it in the data folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}

            formatcb.Text = "auto";
            convertlb.Text = "Add Textures to begin";
		}

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var worker in Threading.Global.Workers)
            {
                worker.Abort();
            }
        }

        private void btadd_Click(object sender, EventArgs e)
		{
            //
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //
                    foreach (var file in ofd.FileNames)
                    {
                        string extension = Path.GetExtension(file);
                        if (!GNF.SupportedExtenstion.Contains(extension))
                        {
                            continue;
                        }

                        if (!filePaths.Contains(file))
                        {
                            filePaths.Add(file);
                        }

                        string name = Path.GetFileName(file);
                        if (!lboxFiles.Items.Contains(name))
                        {
                            lboxFiles.Items.Add(name);
                        }
                    }

                    //
                    if (lboxFiles.Items.Count > 0)
                    {
                        convertlb.Text = lboxFiles.Items.Count + " To be converted ";
                    }
                }
            }
		}

		private void btadddir_Click(object sender, EventArgs e)
		{
            //
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the texture Folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var files = Directory.EnumerateFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories).Where(file => GNF.SupportedExtenstion.Contains(Path.GetExtension(file).ToLower())).ToList();
                    
                    //
                    foreach (string file in files)
                    {
                        if (!filePaths.Contains(file))
                        {
                            filePaths.Add(file);
                        }

                        string path = Path.GetFileName(file);
                        if (!lboxFiles.Items.Contains(path))
                        {
                            lboxFiles.Items.Add(path);
                        }
                    }

                    //
                    if (lboxFiles.Items.Count > 0)
                    {
                        convertlb.Text = lboxFiles.Items.Count + " To be converted ";
                    }
                }
            }
		}

		private void btClear_Click(object sender, EventArgs e)
		{
            foreach (var thread in Threading.Global.Workers)
            {
                thread.Abort();
            }

            //
            lboxFiles.Items.Clear();
			filePaths.Clear();

            //
            lboxFiles.Refresh();

            if (Threading.Global.UIWorker.IsBusy)
            {
                Threading.Global.UIWorker.CancelAsync();
            }

            //
            GNF.Processed = 0;
            progressBar1.Maximum = 0;
			convertlb.Text = lboxFiles.Items.Count + " To be converted ";
		}

		private void credit_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["Credits"] == null && Application.OpenForms["Settings"] == null)
			{
                Settings.Global.ShowDialog();
                Credits.Global.ShowDialog();
			}
		}

		private void lboxFiles_DragDrop(object sender, DragEventArgs e)
		{
            //
            string[] droppedData = (string[])e.Data.GetData(DataFormats.FileDrop);

            //
            var files = droppedData.Where(file => GNF.SupportedExtenstion.Contains(Path.GetExtension(file).ToLower())).ToList();
            foreach (string file in files)
            {
                if (!filePaths.Contains(file))
                { 
                    filePaths.Add(file);
                }

                string path = Path.GetFileName(file);
                if (!lboxFiles.Items.Contains(path))
                {
                    lboxFiles.Items.Add(path);
                }
            }

            //
            var directories = droppedData.Where(text => Directory.Exists(text)).ToArray();
            foreach (string directory in directories)
            {
                var directoryFiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories).Where(file => GNF.SupportedExtenstion.Contains(Path.GetExtension(file).ToLower()) && !filePaths.Contains(file)).ToArray();
                foreach (string directoryFile in directoryFiles)
                {
                    if (!filePaths.Contains(directoryFile))
                    {
                        filePaths.Add(directoryFile);
                    }

                    string path = Path.GetFileName(directoryFile);
                    if (!lboxFiles.Items.Contains(path))
                    {
                        lboxFiles.Items.Add(path);
                    }
                }
            }

            //
            if (lboxFiles.Items.Count > 0)
            {
                convertlb.Text = lboxFiles.Items.Count + " To be converted ";
            }
        }

		private void lboxFiles_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void btstart_Click(object sender, EventArgs e)
		{
            //
			if (lboxFiles.Items.Count <= 0)
			{
				MessageBox.Show("No Textures, aborting..", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            // confirm the BW hasn't already been started.
            if (!Threading.Global.UIWorker.IsBusy)
            {
                Threading.Global.UIWorker.WorkerSupportsCancellation = true;
                Threading.Global.UIWorker.DoWork += UIUpdater;
                Threading.Global.UIWorker.RunWorkerAsync();
            }

            // Set the ProgressBar max equal to the file count and disable the abilty to add the abilty to add items and clear the list.
            progressBar1.Maximum = filePaths.Count;
            btClear.Enabled = false;
            btadd.Enabled = false;
            btadddir.Enabled = false;

            //
            Action<List<string>, Int32> gnfTask = (ListToProcess, threadID) => GNF.Spawn(ListToProcess, threadID);
            List<List<string>> objects = SplitList(filePaths, Threading.GetMaxAllowedTaskCount());

            //
            Threading.Global.DispatchWorker(gnfTask, objects);
        }
    }
}
