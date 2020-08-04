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
    public partial class RTFEditor: UserControl
    {
        public string RTFpath;
        public RTFEditor()
        {
            InitializeComponent();

            richTextBox1.AllowDrop = true;

            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            //richTextBox1.MouseDown += RichTextBox1_MouseDown;

            richTextBox1.Multiline = true;
            richTextBox1.WordWrap = false;


            //setup the file folder under the application
            //DirectoryInfo RootFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            //RTFpath = RootFolder.Parent.Parent.Parent.FullName + "\\Figures\\temp.rtf";


            //Manual input
            //RTFpath = @"C:\Work\MachineVision\Github\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf";

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
            if (richTextBox1.CanPaste(dataFormat))
                richTextBox1.Paste(dataFormat);
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
                        if (richTextBox1.CanPaste(dataFormat))
                            richTextBox1.Paste(dataFormat);

                        //clear the clip board after paste
                        Clipboard.Clear();
                    }


                }
                else
                    MessageBox.Show("No image on the clip board!");

            }
        }



        private void SaveToRTF_Click(object sender, EventArgs e)
        {
            //string RTFpath = @"C:\Work\Programming\C#\WindowsFormsApplication_ObtainImageFromClipBoard\Figures\temp.rtf";            
            //string test = richTextBox1.Text.Trim();

            if (!richTextBox1.Text.Trim().EndsWith(AddMark().Substring(0, AddMark().Length / 2)))//new change item added, sometimes only update some old items.
            {
                richTextBox1.AppendText(appendInfo());
            }

            //there might be some text copied from script or other source
            //so before save, format all the text to default font.
            clearFormat();
            richTextBox1.SaveFile(RTFpath);


        }

        public void LoadFromRTF_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(RTFpath);
            clearFormat();
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
            string userName = "xMan";

            int spaceNum = 30;
            string space = new string(' ', spaceNum);

            return "\n" + space + strTime + "  " + userName + "\n" + AddMark() + "\n";

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





        //search specified text
        private void searchTxt(string txtWord)
        {
            //string txtWord = "CatchMe";
            int index = richTextBox1.Text.IndexOf(txtWord);
            //richTextBox1.Cursor = Cursors.

            //MessageBox.Show("I'm at " + index.ToString());

            //clear previous format
            clearFormat();

            List<int> resultIndexList = new List<int>();
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                int resultIndex = richTextBox1.Find(txtWord.Trim(), i, RichTextBoxFinds.None);
                if (resultIndex != -1)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectionBackColor = Color.Yellow;

                    if (resultIndexList.Count == 0)
                        resultIndexList.Add(resultIndex);
                    else
                    {
                        if (resultIndex != resultIndexList[resultIndexList.Count - 1])
                            resultIndexList.Add(resultIndex);
                    }
                }
            }

            totalResult.Text = resultIndexList.Count.ToString();

            int count = 0;
            char[] splitter = { ' ', '\n' };
            string[] strArr = richTextBox1.Text.Split(splitter);
            //int test = richTextBox1.Text.Split(splitter).Length;

            for (int i = 0; i < strArr.Length; i++)
            {
                //string test2 = richTextBox1.Text.Split(' ')[i];

                if (strArr[i].Trim().ToLower() == txtWord.Trim().ToLower())
                {
                    count = count + 1;
                }
            }


            //MessageBox.Show(count.ToString());
            // lblCount.Text = count.ToString();

        }


        //clear the format
        private void clearFormat()
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBackColor = Color.White;
            Font defaultFont = new Font("Microsoft YaHei", 12); ;
            richTextBox1.SelectionFont = defaultFont;
        }

        //text change function
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                totalResult.Text = "0";
                clearFormat();
            }
            else
            {
                searchTxt(SearchTextBox.Text);

            }
        }

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

        
    }
}
