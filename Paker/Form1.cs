using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Paker
{
    public partial class Form1 : Form
    {
        //For Program.cs
        bool reset = false;
        bool looping = true;
        public bool Looping
        {
            get { return looping; }
            set { looping = value; }

        }

        //Initialize
        public Form1()
        {
            InitializeComponent();
            looping = true;
            //all.main = this;
        }

        //Reset
        public void ResetLocalData()
        {
        }
        public void ResetControls()
        {
        }

        //Loop
        public void Update()
        {
            FillProgressBar();
            FillStatusStrip();
        }
        public void Render()
        {
        }

        //Exit
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            looping = false;
            // all.main = null;
        }

        //---------------------------------------------------------------------------

        //Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //File
        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFiles();
        }
        private void remFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemFiles();
        }
        private void exportFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportFiles();
        }
        private void importPAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportPak();
        }

        //Loader
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateLoader();
        }

        //Menu Button Strip
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void tsbut_UP_Click(object sender, EventArgs e)
        {
            MoveUp();
        }
        private void tsbut_down_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        //Controls
        private void but_AddFiles_Click(object sender, EventArgs e)
        {
            AddFiles();
        }
        private void but_RemFiles_Click(object sender, EventArgs e)
        {
            RemFiles();
        }
        private void but_ExportFiles_Click(object sender, EventArgs e)
        {
            ExportFiles();
        }
        private void but_ImportPak_Click(object sender, EventArgs e)
        {
            ImportPak();
        }

        //Signature
        private void textBox_Sig_TextChanged(object sender, EventArgs e)
        {
            all.pak.mainHeader.signature = textBox_Sig.Text;
        }

        //---------------------------------------------------------------------------

        //Helper Functions
        public void FillList(bool keepIndex)
        {
            reset = true;
            ListView.SelectedIndexCollection collection = listView_Main.SelectedIndices;
            listView_Main.Items.Clear();

            for (int i = 0; i < all.pak.atlas.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = all.pak.atlas[i].fileName;
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = all.pak.atlas[i].byteLength.ToString();
                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                float mb = all.pak.atlas[i].byteLength / (float)all.MB;
                subItem2.Text = mb.ToString("0.00");
                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                subItem3.Text = GetExt(all.pak.atlas[i].fileName);
                //ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem();
                //subItem4.Text = (all.pak.atlas[i].isInPak) ? "True" : "False";
                item.SubItems.Add(subItem);
                item.SubItems.Add(subItem2);
                item.SubItems.Add(subItem3);
                //item.SubItems.Add(subItem4);
                listView_Main.Items.Add(item);
            }

            if (keepIndex)
                for (int i = 0; i < collection.Count; i++)
                    if (collection[i] < listView_Main.Items.Count)
                        listView_Main.SelectedIndices.Add(collection[i]);
            reset = false;
        }
        public void FillProgressBar()
        {
            float percent = 100.0f * all.pak.GetTotalBytes() / all.MAXSIZE;
            if (percent > 100)
                percent = 100.0f;

            progressBar.Value = (int)percent;
        }
        public void FillStatusStrip()
        {
            tssl_Files.Text = all.pak.atlas.Count.ToString();
            tssl_Bytes.Text = /*progressBar.Value.ToString();*/(all.pak.GetTotalBytes() / (float)all.MB).ToString("0.000");
            tssl_FreeBytes.Text = ((all.MAXSIZE - all.pak.GetTotalBytes()) / (float)all.MB).ToString("0.000");
        }
        public void FillSignature()
        {
            reset = true;
            textBox_Sig.Text = all.pak.mainHeader.signature;
            reset = false;
        }
        public void AddFile(string file)
        {
            FileStream stream = null;
            try
            {
                stream = File.Open(file, FileMode.Open);
            }
            catch
            {
                DialogResult box = MessageBox.Show("The file: |" + file + "| couldn't be added.");
                return;
            }
            int index = file.Length - 1;
            while (true)
            {
                if (file[index] == '\\')
                    break;
                index--;
            }
            index++;

            //Make new directory entry
            Directory dir = new Directory();
            long length = stream.Length;
            dir.byteLength = (int)length;
            dir.byteOffset = all.pak.mainHeader.directoryOffset;
            dir.fileName = file.Remove(0, index);
            dir.filePath = file;
            dir.isInPak = false;

            stream.Close();

            //Check if the byte length will end up negative because of overflow
            if (length > int.MaxValue)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.filePath + "| is too large to store. This file has been skipped.");
                return;
            }

            //Check if the file is already in the pak
            bool skip = false;
            for (int i = 0; i < all.pak.atlas.Count; i++)
                if (dir.filePath == all.pak.atlas[i].filePath)
                    skip = true;
            if (skip)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.filePath + "| already exists in the pak file. This file has been skipped.");
                return;
            }

            //Check if the file will put the total byte size over
            long size = (long)all.pak.GetTotalBytes() + (long)dir.byteLength + (long)dir.GetStructureByteSize();
            if (size > all.MAXSIZE)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.filePath + "| will put the pak file over the maxsize of" + ((float)(all.MAXSIZE / all.GB)).ToString() + "GB. This file has been skipped.");
                return;
            }

            //Check if the name is short enough
            if (dir.fileName.Length > 56)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.filePath + "| has a filename that is over 56 chars. This file has been skipped.");
                return;
            }

            //Add directory to the atlas
            all.pak.atlas.Add(dir);

            //Update the Header
            all.pak.mainHeader.directoryLength += dir.GetStructureByteSize();
            all.pak.mainHeader.directoryOffset += dir.byteLength;

        }
        private void RemFile(int index)
        {
            //Get temp copy of data to remove
            Directory dir = all.pak.atlas[index];
            //Remove the data
            all.pak.atlas.RemoveAt(index);
            //Adjust the header
            all.pak.mainHeader.directoryLength -= dir.GetStructureByteSize();
            all.pak.mainHeader.directoryOffset -= dir.byteLength;
        }
        private string GetExt(string file)
        {
            int index = file.Length - 1;
            while (true)
            {
                if (index == 0 && file[index] != '.')
                    return "";
                if (file[index] == '.')
                    break;
                index--;
            }

            return file.Remove(0, index);
        }
        private void Swap(int index1, int index2)
        {
            if (index1 < 0 || index2 < 0 || index1 >= all.pak.atlas.Count || index2 >= all.pak.atlas.Count)
                return;

            Directory dirTemp = new Directory(all.pak.atlas[index1]);
            all.pak.atlas[index1] = new Directory(all.pak.atlas[index2]);
            all.pak.atlas[index2] = new Directory(dirTemp);
        }
        private Pak LoadPak(FileStream stream)
        {
            //Create new pak file
            Pak temp = new Pak();

            //Get the header
            if (!temp.mainHeader.ReadHeaderFromStream(stream, textBox_Sig.Text))
            {
                DialogResult box = MessageBox.Show("The signature '" + textBox_Sig.Text + "' does not match the pak file you wish to load. The load has been aborted.");
                return null;
            }

            //Get the directories
            Directory dir = new Directory();
            int numDir = temp.mainHeader.directoryLength / dir.GetStructureByteSize();
            for (int i = 0; i < numDir; i++)
            {
                int offset = temp.mainHeader.directoryOffset + i * dir.GetStructureByteSize();
                dir = new Directory();
                dir.ReadHeaderFromStream(stream, offset);
                temp.atlas.Add(dir);
            }

            //Get the files
            for (int i = 0; i < numDir; i++)
                temp.atlas[i].ReadFileFromPak(stream);

            return temp;
        }
        private void ImportPakDirectory(Directory dir)
        {
            //Check if the file is already in the pak
            bool skip = false;
            for (int i = 0; i < all.pak.atlas.Count; i++)
                if (dir.fileName == all.pak.atlas[i].fileName)
                    skip = true;
            if (skip)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.fileName + "| already exists in the pak file. This file has been skipped.");
                return;
            }

            //Check if the file will put the total byte size over
            if (all.pak.GetTotalBytes() + dir.byteLength > all.MAXSIZE)
            {
                DialogResult box = MessageBox.Show("The file: |" + dir.fileName + "| will put the pak file over the maxsize of" + ((float)(all.MAXSIZE / all.GB)).ToString() + "GB. This file has been skipped.");
                return;
            }

            //Add directory to the atlas
            all.pak.atlas.Add(dir);

            //Update the Header
            all.pak.mainHeader.directoryLength += dir.GetStructureByteSize();
            all.pak.mainHeader.directoryOffset += dir.byteLength;
        }

        //Main Functions
        public void New()
        {
            all.pak = new Pak();
            FillList(false);
        }
        public void Open()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //Do filepath check
            if (all.savePath != "")
                dlg.InitialDirectory = all.savePath;
            dlg.DefaultExt = ".pak";
            if (DialogResult.OK != dlg.ShowDialog())
                return;
            all.savePath = all.GetPath(dlg.FileName);

            FileStream stream = File.Open(dlg.FileName, FileMode.Open);
            all.pak = LoadPak(stream);

            if (all.pak == null)
                New();

            FillList(false);

            stream.Close();

        }
        public void Save()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            //Do filepath check
            if (all.savePath != "")
                dlg.InitialDirectory = all.savePath;
            dlg.AddExtension = true;
            dlg.DefaultExt = ".pak";
            if (DialogResult.OK != dlg.ShowDialog())
                return;
            all.savePath = all.GetPath(dlg.FileName);

            //Fill all directories with data
            for (int i = 0; i < all.pak.atlas.Count; i++)
            {
                if (all.pak.atlas[i].isInPak)
                    continue;
                try
                {
                    FileStream stream = File.Open(all.pak.atlas[i].filePath, FileMode.Open);
                    all.pak.atlas[i].ReadFileFromStream(stream);
                    stream.Close();
                }
                catch
                {
                    DialogResult box = MessageBox.Show("Either the file: |" + all.pak.atlas[i].filePath + "| couldn't be found, or the file couldn't be loaded into the Paker. No export can take place.");
                    return;
                }
            }

            //Create New Pak File
            FileStream streamPak = File.Open(dlg.FileName, FileMode.Create);

            //Write Header
            all.pak.mainHeader.WriteHeaderToStream(streamPak);

            //Write Files
            for (int i = 0; i < all.pak.atlas.Count; i++)
                all.pak.atlas[i].WriteFileToStream(streamPak, all.pak.atlas[i].byteOffset);

            //Write Atlas
            for (int i = 0; i < all.pak.atlas.Count; i++)
                all.pak.atlas[i].WriteHeaderToStream(streamPak, all.pak.mainHeader.directoryOffset + i * all.pak.atlas[i].GetStructureByteSize());

            streamPak.Close();
        }
        public void AddFiles()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (all.filePath != "")
                dlg.InitialDirectory = all.filePath;

            dlg.Multiselect = true;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                all.filePath = all.GetPath(dlg.FileName);
                //Add each thing to the atlas
                foreach (String file in dlg.FileNames)
                    AddFile(file);
            }

            //This is just for testing
            bool testing = false;
            if (testing)
            {
                //Fill all directories with data
                for (int i = 0; i < all.pak.atlas.Count; i++)
                {
                    if (all.pak.atlas[i].isInPak)
                        continue;
                    try
                    {
                        FileStream stream = File.Open(all.pak.atlas[i].filePath, FileMode.Open);
                        all.pak.atlas[i].ReadFileFromStream(stream);
                        stream.Close();
                    }
                    catch
                    {
                        DialogResult box = MessageBox.Show("The file: |" + all.pak.atlas[i].filePath + "| couldn't be loaded.");
                    }
                }
            }

            FillList(true);
        }
        public void RemFiles()
        {
            ListView.SelectedIndexCollection collection = listView_Main.SelectedIndices;
            for (int i = 0; i < collection.Count; i++)
                RemFile(collection[i] - i);
            FillList(false);
        }
        public void ExportFiles()
        {
            ListView.SelectedIndexCollection collection = listView_Main.SelectedIndices;
            if (collection.Count == 0)
                return;
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    string filepath = dlg.SelectedPath + "\\" + all.pak.atlas[collection[i]].fileName;

                    //IF the file is not in ram, then we need to load it to write it
                    if (!all.pak.atlas[collection[i]].isInPak)
                    {
                        FileStream stream = File.Open(all.pak.atlas[collection[i]].filePath, FileMode.Open);
                        if (stream == null)
                        {
                            DialogResult box = MessageBox.Show("The file: |" + all.pak.atlas[collection[i]].filePath + "| was not yet stored in the Paker. Therefore it's filepath was searched for, but the file was not found at the location. This file has been skipped.");
                            continue;
                        }
                        all.pak.atlas[collection[i]].ReadFileFromStream(stream);
                        stream.Close();
                    }
                    //Now that we have the file write it to the stream
                    FileStream stream2 = File.Open(filepath, FileMode.Create);
                    all.pak.atlas[collection[i]].WriteFileToStream(stream2, 0);
                    stream2.Close();
                }
            }
        }
        public void ImportPak()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".pak";
            if (all.importPath != "")
                dlg.InitialDirectory = all.importPath;
            if (DialogResult.OK != dlg.ShowDialog())
                return;
            all.importPath = all.GetPath(dlg.FileName);

            FileStream stream = File.Open(dlg.FileName, FileMode.Open);
            Pak temp = LoadPak(stream);

            if (temp == null)
                return;

            for (int i = 0; i < temp.atlas.Count; i++)
                ImportPakDirectory(temp.atlas[i]);

            FillList(true);

            stream.Close();
        }
        public void CreateLoader()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.DefaultExt = ".h";
            if (DialogResult.OK != dlg.ShowDialog())
                return;

            FileStream stream = File.Open(dlg.FileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);

            string pakerH = Properties.Resources.Paker;

            //Adjust the file for loading
            //  line 15 -   #define SIGNATURE_LENGTH 4
            //  line 16 -   const char SIG[] = {'P','A','C','K'};
            int count = 0;
            int line = 0;
            while (line != 15)
            {
                if (pakerH[count] == '\n')
                    line++;
                count++;
            }
            string signLen = "#define SIGNAUTURE_LENGTH " + all.pak.mainHeader.signature.Length.ToString() + "\r\n";
            string sigAry = "const char SIG[] = " + all.GetAsCharArray(all.pak.mainHeader.signature) + ';';
            pakerH = pakerH.Insert(count, sigAry);
            pakerH = pakerH.Insert(count, signLen);
            string test = pakerH.Remove(0, count);


            byte[] data = Encoding.ASCII.GetBytes(pakerH);
            writer.Write(data);
            writer.Close();
            stream.Close();

        }
        public void MoveUp()
        {
            ListView.SelectedIndexCollection collection = listView_Main.SelectedIndices;
            if (collection.Count == 0)
                return;
            if (collection[0] == 0)
                return;

            List<int> indicies = new List<int>();

            for (int i = 0; i < collection.Count; i++)
            {
                Swap(collection[i], collection[i] - 1);
                indicies.Add(collection[i] - 1);
            }

            FillList(true);
            for (int i = 0; i < indicies.Count; i++)
                listView_Main.SelectedIndices.Add(indicies[i]);

        }
        public void MoveDown()
        {
            ListView.SelectedIndexCollection collection = listView_Main.SelectedIndices;
            if (collection.Count == 0)
                return;
            if (collection[collection.Count - 1] == all.pak.atlas.Count - 1)
                return;

            List<int> indicies = new List<int>();

            for (int i = collection.Count - 1; i >= 0; i--)
            {
                Swap(collection[i], collection[i] + 1);
                indicies.Add(collection[i] + 1);
            }

            FillList(true);
            for (int i = 0; i < indicies.Count; i++)
                listView_Main.SelectedIndices.Add(indicies[i]);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Daniel Habig\n\t2013");
        }


        //Drag Drop
        private void listView_Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void listView_Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
            {
                string ext = GetExt(file);
                if (ext == ".pak")
                {
                    all.importPath = all.GetPath(file);

                    FileStream stream = File.Open(file, FileMode.Open);
                    Pak temp = LoadPak(stream);

                    if (temp == null)
                        return;

                    for (int i = 0; i < temp.atlas.Count; i++)
                        ImportPakDirectory(temp.atlas[i]);

                    FillList(true);

                    stream.Close();
                }
                else
                {
                    all.filePath = all.GetPath(file);
                    AddFile(file);
                }
            }
            FillList(true);
        }

        
    }
}
