using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RTFEditorUI
{
    public partial class RTFEditor : UserControl
    {
        private string RTFpath;
        public string strVersion = "x.x.x.x";
        public string userName = "xMan";
        public string rtfOriginContent = string.Empty;

        public void setRTFPath(string sourceFilePath)
        {
            RTFpath = sourceFilePath;
            
        }
        public RTFEditor()
        {
            InitializeComponent();

            richTextBox.AllowDrop = true;

            richTextBox.DragDrop += RichTextBox1_DragDrop;
            richTextBox.DragEnter += RichTextBox1_DragEnter;
            //richTextBox1.MouseDown += RichTextBox1_MouseDown;

            richTextBox.Multiline = true;
            richTextBox.WordWrap = false;



            //setup the file folder under the application
            //DirectoryInfo RootFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            //RTFpath = RootFolder.Parent.Parent.Parent.FullName + "\\Figures\\temp.rtf";


            //Manual input
            //RTFpath = @"C:\Work\MachineVision\Github\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf";

        }

        //get the content from the first richtextbox
        public string getRichTextBoxContent()
        {
            return richTextBox.Rtf;
        }


        //drag the object to the target "richTextBox"
        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        //release mouse to complete this operation
        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            //richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
            Bitmap bmp = new Bitmap(path);

            Clipboard.SetDataObject(bmp);
            DataFormats.Format dataFormat =
            DataFormats.GetFormat(DataFormats.Bitmap);
            if (richTextBox.CanPaste(dataFormat))
                richTextBox.Paste(dataFormat);
        }


        //release mouse to complete this operation
        //change the method from right-click event to clipboard.
        private void PasteImage()
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (Clipboard.ContainsImage())
                {
                    //var confirmRes = MessageBox.Show("Sure to paste?", "Confirm paste!", MessageBoxButtons.YesNo);
                    //if (confirmRes == DialogResult.Yes)
                    {
                        DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (richTextBox.CanPaste(dataFormat))
                            richTextBox.Paste(dataFormat);

                        //clear the clip board after paste
                        Clipboard.Clear();
                    }


                }
                else
                    MessageBox.Show("No image on the clip board!");

            }
        }

        //Append txt to the file
        public void AppendText(string strNewText)
        {
            richTextBox.AppendText(strNewText);

        }


        //save to RTF file, save with signing
        public void SaveToRTF(bool withSignature)
        {
            //string RTFpath = @"C:\Work\Programming\C#\WindowsFormsApplication_ObtainImageFromClipBoard\Figures\temp.rtf";            
            //string test = richTextBox1.Text.Trim();

            if (withSignature)
            {
                if (!richTextBox.Text.Trim().EndsWith(AddMark().Substring(0, AddMark().Length / 2)))//new change item added, sometimes only update some old items.
                {
                    richTextBox.AppendText(appendInfo());
                }
            }

            //there might be some text copied from script or other source
            //so before save, format all the text to default font.
            clearFormat();
            richTextBox.SaveFile(RTFpath);

            //After saved successfully, update the rtfOriginContent. 
            //won't release this function, so comment it.
            //rtfOriginContent = richTextBox.Rtf;

        }

     


        public void LoadFromRTF()
        {
            richTextBox.LoadFile(RTFpath);
            clearFormat();

            //save the content temporarily
            rtfOriginContent = richTextBox.Rtf;
        }

        //check whether the content status, is modified or not
        public bool isModified()
        {
            return string.Equals(rtfOriginContent, richTextBox.Rtf) ? false : true;
        }


        private void LaunchRTF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(RTFpath);
        }


        //add tag in the ending
        private string appendInfo()
        {
            //add date and operation
            string strTime = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");


            int spaceNum = 30;
            string space = new string(' ', spaceNum);

            return "\n" + space + strTime + "  " + "Version: " + strVersion + "  by " + userName + "\n" + AddMark() + "\n";

        }
        
        //add mark as starter
        private string AddMark()
        {
            string strSingleMark = "+";
            int nRepeat = 40;
            string strMark = string.Empty;

            for (int i = 0; i < nRepeat; i++)
            {
                strMark += strSingleMark;
            }

            return strMark;

        }

        //set search text
        public void SetSearchText(string txtWord)
        {
            SearchTextBox.Text = txtWord;
        }


        //search specified text
        public void searchTxt(string txtWord)
        {
            if (txtWord == "")
            {
                totalResult.Text = "0";
            }
            else
            {
                //string txtWord = "CatchMe";
                //int index = richTextBox.Text.IndexOf(txtWord);
                //richTextBox1.Cursor = Cursors.

                //MessageBox.Show("I'm at " + index.ToString());

                //clear previous format

                /*
                List<int> resultIndexList = new List<int>();
                for (int i = 0; i < richTextBox.TextLength; i++)
                {
                    int resultIndex = richTextBox.Find(txtWord.Trim(), i, RichTextBoxFinds.None);
                    if (resultIndex != -1)
                    {
                        richTextBox.SelectionColor = Color.Red;
                        richTextBox.SelectionBackColor = Color.Yellow;

                        if (resultIndexList.Count == 0)
                            resultIndexList.Add(resultIndex);
                        else
                        {
                            if (resultIndex != resultIndexList[resultIndexList.Count - 1])
                                resultIndexList.Add(resultIndex);
                        }
                    }
                }*/

                //reformat the function.
                List<int> resultIndexList = searchThenLocate(txtWord);

                totalResult.Text = resultIndexList.Count.ToString();

                //locate the cursor in the first existence
                if (resultIndexList.Count > 0)
                {
                    int firstIndex = resultIndexList[0];
                    richTextBox.Select(firstIndex, 0);
                    richTextBox.Focus();
                }
                /*
                int count = 0;
                char[] splitter = { ' ', '\n' };
                string[] strArr = richTextBox.Text.Split(splitter);
                //int test = richTextBox1.Text.Split(splitter).Length;

                for (int i = 0; i < strArr.Length; i++)
                {
                    //string test2 = richTextBox1.Text.Split(' ')[i];

                    if (strArr[i].Trim().ToLower() == txtWord.Trim().ToLower())
                    {
                        count = count + 1;
                    }
                }*/

                
            }
        }


        //search the specified text
        public List<int> searchThenLocate(string txtWord)
        {
            clearFormat();
            List<int> resultIndexList = new List<int>();

            for (int i = 0; i < richTextBox.TextLength; i++)
            {
                int resultIndex = richTextBox.Find(txtWord.Trim(), i, RichTextBoxFinds.None);
                if (resultIndex != -1)
                {
                    richTextBox.SelectionColor = Color.Red;
                    richTextBox.SelectionBackColor = Color.Yellow;

                    if (resultIndexList.Count == 0)
                        resultIndexList.Add(resultIndex);
                    else
                    {
                        if (resultIndex != resultIndexList[resultIndexList.Count - 1])
                            resultIndexList.Add(resultIndex);
                    }
                }
            }
            return resultIndexList;
        }

        //locate the string then replace with a different one
        public bool replaceText(string oldValue, string updatedValue)
        {
            bool bOK = true;

            try
            {
                List<int> resultIndexList = searchThenLocate(oldValue);

                //string updatedRTF = richTextBox.Text.Replace(oldValue, updatedValue);

                //richTextBox.Text = updatedRTF;
                int num = 0;
                int offset = updatedValue.Length - oldValue.Length;
                foreach (int index in resultIndexList)
                {
                    richTextBox.Select(index + offset * num, oldValue.Length);
                    richTextBox.SelectedText = updatedValue;
                    num++; //the count have replaced.
                }
            }
            catch(Exception ex)
            {
                bOK = false;

            }
            //richTextBox.Update();

            return bOK;
        }



        //clear the format
        public void clearFormat()
        {
            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;
            richTextBox.SelectionBackColor = Color.White;
            Font defaultFont = new Font("Microsoft YaHei", 12); 
            richTextBox.SelectionFont = defaultFont;
        }

        //text change function
        //time-consuming, about 500-900 millisecond.
        /* 
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (SearchTextBox.Text == "")
            {
                totalResult.Text = "0";
                clearFormat();
            }
            else
            {
                if ((DateTime.Now - lastRunTime).TotalMilliseconds > IntervalMS)
                {
                    //update the lastRunTime
                    lastRunTime = DateTime.Now;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();

                    searchTxt(SearchTextBox.Text);

                    sw.Stop();
                    MessageBox.Show(sw.ElapsedMilliseconds.ToString());
                }
            }
        }*/


        private void RestoreFormat_Click(object sender, EventArgs e)
        {
            clearFormat();

        }

        private void InsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIF|All files (*.*)|*.*"; //set anticipated file type.
                                                                                                                         //  Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            var dialogResult = ofd.ShowDialog();
            //load the image to clipboard, and paste in the richtextbox.
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap img = new Bitmap(ofd.FileName);
                //var obj = Clipboard.GetDataObject();              
                Clipboard.SetDataObject(img);
                PasteImage();
            }

        }

        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            clearSearch();
        }

        //clear the search 
        public void clearSearch()
        {
            SearchTextBox.Text = "";
            totalResult.Text = "0";
            clearFormat();

        }

        //search text by click the button
        private void btn_Search_Click(object sender, EventArgs e)
        {
           
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            searchTxt(SearchTextBox.Text);

            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());
            //searchTxt(SearchTextBox.Text);
            
        }


        //event when "Enter" pressed
        private void enterToSearch(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                searchTxt(SearchTextBox.Text); 

        }

        //merge the RTF files
        public void MergeRTFs(List<Tuple<string, List<string>>> srcFileList, string outpuFullName)
        {
            RichTextBox mergeRTF = new RichTextBox();
            mergeRTF.Font = new Font("Microsoft YaHei", 12);

            foreach (Tuple<string, List<string>> eachBranch in srcFileList)
            {
                RichTextBox singleRTF = new RichTextBox();
                foreach (string singleRTFFileName in eachBranch.Item2)
                {
                    singleRTF.LoadFile(singleRTFFileName);
                    mergeRTF.AppendText("\n" + "\n" + "*******" + eachBranch.Item1 + ", " + System.IO.Path.GetFileName(singleRTFFileName) + "*******" + "\n" + "\n");
                    singleRTF.SelectAll();
                    mergeRTF.SelectedRtf = singleRTF.SelectedRtf;
                }
            }
            mergeRTF.SaveFile(outpuFullName);
        }


    }
}