using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSE_Fallout_4_Texture_Converter
{
    public partial class Main : Form
    {
        private List<string> filePaths = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("DDS");
            /// thse are what you see when you hover over the buttons
            toolTip1.SetToolTip(this.btadd, "This is to add them one by one");
            toolTip1.SetToolTip(this.btadddir, "This is for adding a dirtory");
            toolTip1.SetToolTip(this.btClear, "this will purge the list");
            toolTip1.SetToolTip(this.credit, "This will open the credit");
            toolTip1.SetToolTip(this.btstart, "this will start the ");
            /// this will check to see if the at9tool is present
            if (File.Exists("data\\orbis-image2gnf.exe"))
            {

            }
            else
            {
                MessageBox.Show("orbis-image2gnf.exe is missing please put it in the data folder", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            /// this will check to see if xWMAEncode.exe is present
            if (File.Exists("Data\\libSceGnm.dll"))
            {

            }
            else
            {
                MessageBox.Show("libSceGnm.dll is missing please put it in the data folder", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            /// this will check to see if "fuz_extractor.exe" is present
            if (File.Exists("Data\\libSceGpuAddress.dll"))
            {

            }
            else
            {
                MessageBox.Show("libSceGpuAddress.dll is missing please put it in the data folder", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (File.Exists("Data\\libSceTextureTool.dll"))
            {

            }
            else
            {
                MessageBox.Show("libSceTextureTool.dll is missing please put it in the data folder", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            /// this is going to show the Mesagebox that give the warning if anything is missing it might now work like its suppost to
            MessageBox.Show("if any other required tools are missing this will not work right", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("Due to legail reasons i can't include the required tools you will need to find them yourself", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (comboBox1.Text == "")
            {
                comboBox1.SelectedIndex = -0;
            }
            label1.Text = "Add Textures to begin";
        }
        
        private void btadd_Click(object sender, EventArgs e)
        {
            /// this is going to add files via the add file button to the listbox
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.ShowDialog();
            filePaths.AddRange(OFD.FileNames);
            for (int i = 0; i < filePaths.Count; i++)
            {
                lboxFiles.Items.Add(OFD.SafeFileNames[i]);
            }
            /// this is going to tell the system that label is the count of the listbox and the " To be converted "
            /// IE, "5 To be converted "
            label1.Text = lboxFiles.Items.Count + " To be converted ";
        }

        private void btadddir_Click(object sender, EventArgs e)
        {
            /// this is going to add all files via the add dir to the listbox
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Select the texture Folder";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(FBD.SelectedPath, "*.dds", SearchOption.AllDirectories);
                foreach (string dds in files)
                {
                    if (!filePaths.Contains(dds))
                    {
                        lboxFiles.Items.Add(Path.GetFileName(dds));
                        filePaths.Add(dds);
                        label1.Text = lboxFiles.Items.Count + " To be converted ";
                    }
                }
                files = Directory.GetFiles(FBD.SelectedPath, "*.tga", SearchOption.AllDirectories);
                foreach (string tgafiles in files)
                {
                    if (!filePaths.Contains(tgafiles))
                    {
                        lboxFiles.Items.Add(Path.GetFileName(tgafiles));
                        filePaths.Add(tgafiles);
                        label1.Text = lboxFiles.Items.Count + " To be converted ";
                    }
                }
                files = Directory.GetFiles(FBD.SelectedPath, "*.png", SearchOption.AllDirectories);
                foreach (string pngfiles in files)
                {
                    if (!filePaths.Contains(pngfiles))
                    {
                        lboxFiles.Items.Add(Path.GetFileName(pngfiles));
                        filePaths.Add(pngfiles);
                        label1.Text = lboxFiles.Items.Count + " To be converted ";
                    }
                }
            }
            /// this is going to tell the system that label is the count of the listbox and the " To be converted "
            /// IE, "5 To be converted "
            label1.Text = lboxFiles.Items.Count + " To be converted ";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            /// this is going to clear the list box
            lboxFiles.Items.Clear();
            /// this is going to refresh the listbox
            lboxFiles.Refresh();
            /// this is going to clear the list of file that where in the listbox
            filePaths.Clear();
            /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
            progressBar1.Maximum = lboxFiles.Items.Count;
            /// this is going to tell the system that label is the count of the listbox and the " To be converted "
            /// IE, "5 To be converted "
            label1.Text = lboxFiles.Items.Count + " To be converted ";
        }

        private void lboxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string all in array)
            {
                if ((Path.GetExtension(all) == ".dds" || Path.GetExtension(all) == ".tga" || Path.GetExtension(all) == ".DDS" || Path.GetExtension(all) == ".TGA" || Path.GetExtension(all) == ".png" || Path.GetExtension(all) == ".PNG") && !filePaths.Contains(all))
                {
                    lboxFiles.Items.Add(Path.GetFileName(all));
                    filePaths.Add(all);
                    label1.Text = lboxFiles.Items.Count + " To be converted ";
                }
                if (Directory.Exists(all))
                {
                    string[] files = Directory.GetFiles(all, "*.dds", SearchOption.AllDirectories);
                    foreach (string dds in files)
                    {
                        if (!filePaths.Contains(dds))
                        {
                            lboxFiles.Items.Add(Path.GetFileName(dds));
                            filePaths.Add(dds);
                            label1.Text = lboxFiles.Items.Count + " To be converted ";
                        }
                    }
                    files = Directory.GetFiles(all, "*.tga", SearchOption.AllDirectories);
                    foreach (string tga in files)
                    {
                        if (!filePaths.Contains(tga))
                        {
                            lboxFiles.Items.Add(Path.GetFileName(tga));
                            filePaths.Add(tga);
                            label1.Text = lboxFiles.Items.Count + " To be converted ";
                        }
                    }
                    files = Directory.GetFiles(all, "*.png", SearchOption.AllDirectories);
                    foreach (string png in files)
                    {
                        if (!filePaths.Contains(png))
                        {
                            lboxFiles.Items.Add(Path.GetFileName(png));
                            filePaths.Add(png);
                            label1.Text = lboxFiles.Items.Count + " To be converted ";
                        }
                    }
                }
            }
        }

        private void lboxFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private void credit_Click(object sender, EventArgs e)
        {
            /// this is going to open the credits window
            if (Application.OpenForms["Credits"] == null)
            {
                Credits form = new Credits();
                form.Show();
            }
        }

        private string getFileName(string path)
        {
            path = path.Replace("\\", ",");
            string[] pathSplit = path.Split(',');
            return pathSplit[pathSplit.Length - 1];
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Pick a Texture Format");
            }
            else if (lboxFiles.Items.Count == 0)
            {
                MessageBox.Show("No Textures to convert found please add them", "warnng", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            /// this is going to create the dirtory dds
            Directory.CreateDirectory("dds");
            Directory.CreateDirectory("tga");
            Directory.CreateDirectory("png");
            /// this is going to pass the dirtory info
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\dds\\");
            FileInfo[] files = info.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            for (int i = 0; i < filePaths.Count; i++)
            {
                if (filePaths[i].Contains(".dds"))
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".dds", ".gnf") + "\" -f " + comboBox1.Text;
                    process.Start();
                    process.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".dds", ".gnf"), (filePaths[i].ToString().Replace(".gnf", ".dds")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }
                else if (filePaths[i].Contains(".tga"))
                {
                    Process process1 = new Process();
                    process1.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process1.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".tga", ".tgagnf") + "\" -f " + comboBox1.Text;
                    process1.Start();
                    process1.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".tga", ".tgagnf"), (filePaths[i].ToString().Replace(".tgagnf", ".tga")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }
                if (filePaths[i].Contains(".DDS"))
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".DDS", ".gnf") + "\" -f " + comboBox1.Text;
                    process.Start();
                    process.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".DDS", ".gnf"), (filePaths[i].ToString().Replace(".gnf", ".DDS")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }

                if (filePaths[i].Contains(".TGA"))
                {
                    Process process1 = new Process();
                    process1.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process1.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".TGA", ".tgagnf") + "\" -f " + comboBox1.Text;
                    process1.Start();
                    process1.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".TGA", ".tgagnf"), (filePaths[i].ToString().Replace(".tgagnf", ".TGA")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }

                if (filePaths[i].Contains(".png"))
                {
                    Process process1 = new Process();
                    process1.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process1.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".png", ".pnggnf") + "\" -f " + comboBox1.Text;
                    process1.Start();
                    process1.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".png", ".pnggnf"), (filePaths[i].ToString().Replace(".pnggnf", ".png")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }

                if (filePaths[i].Contains(".PNG"))
                {
                    Process process1 = new Process();
                    process1.StartInfo.FileName = "Data\\orbis-image2gnf.exe";
                    process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process1.StartInfo.Arguments = "-i \"" + filePaths[i] + "\" -o \"" + filePaths[i].ToString().Replace(".PNG", ".PNGgnf") + "\" -f " + comboBox1.Text;
                    process1.Start();
                    process1.WaitForExit();
                    File.Delete(filePaths[i]);
                    File.Move(filePaths[i].ToString().Replace(".PNG", ".PNGgnf"), (filePaths[i].ToString().Replace(".PNGgnf", ".PNG")));
                    /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
                    progressBar1.Maximum = lboxFiles.Items.Count;
                    /// This is going to make it so you can see the bar move
                    System.GC.Collect();
                    /// this is going to make it move
                    progressBar1.Value++;
                }

                /// this checks to see if they are all done converting
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    /// this is going to show the messege box
                    MessageBox.Show("Your Textures are converted!", "Finished!");
                    label1.Text = "Finished";
                    filePaths.Clear();
                    lboxFiles.Items.Clear();
                    progressBar1.Value = 0;
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists("dds"))
            {
                Directory.Delete("dds");
            }
            if (Directory.Exists("tga"))
            {
                Directory.Delete("tga");
            }
            if (Directory.Exists("png"))
            {
                Directory.Delete("png");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}