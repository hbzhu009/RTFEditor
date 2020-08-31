using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_IntegrateRTFEditor
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            rtfEditor1.setRTFPath(@"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf");

            //rtfEditor1.RTFpath = @"C:\Users\hbzhu\Desktop\temp.rtf";
            //rtfEditor1.LoadFromRTF();

            

            //richTextBox2.Rtf = curRTBContent;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            rtfEditor1.userName = "CognexAdministrator";
            rtfEditor1.strVersion = "3.1.5.0";
            rtfEditor1.SaveToRTF(true);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            //rtfEditor1.RTFpath = @"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf";
            //rtfEditor1.RTFpath = @"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\";
            rtfEditor1.LoadFromRTF();

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            string curRTBContent = rtfEditor1.getRichTextBoxContent();
            rtfEditor1.richTextBox.Clear();
            rtfEditor1.richTextBox.Rtf = curRTBContent;
        }

        private void AppendText_Click(object sender, EventArgs e)
        {
            rtfEditor1.AppendText(textBox_NewText.Text);
            
        }

        private void CheckDelta_Click(object sender, EventArgs e)
        {
            //StatusLabel.Text = string.Equals(rtfEditor1.richTextBox.Rtf, rtfOriginContent) ? "NoChange" : "Changed";
            StatusLabel.Text = rtfEditor1.isModified() ?"Modified":"NoChange";
        }

        private void btn_MergeRTF_Click(object sender, EventArgs e)
        {
            List<Tuple<string, List<string>>> srcFileList = new List<Tuple<string, List<string>>>();

            //branch1 RTFs
            List<string> branchList1 = new List<string>();
            branchList1.Add(@"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T11_LocateHSG.rtf");
            branchList1.Add(@"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T11_LocateNozzle_1.rtf");
            srcFileList.Add(new Tuple<string, List<string>>("Branch1", branchList1));

            //branch2 RTFs
            List<string> branchList2 = new List<string>();
            branchList2.Add(@"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T12_FinalCheck.rtf");
            srcFileList.Add(new Tuple<string, List<string>>("Branch2", branchList2));
            rtfEditor1.MergeRTFs(srcFileList, @"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\Merged.rtf");

        }

        //C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T11_LocateHSG.rtf
        //C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T31_LocateNozzle.rtf
        //C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\MergeRTFs\T12_FinalCheck.rtf

        //MergeRTs
        

        private void button1_Click(object sender, EventArgs e)
        {
            rtfEditor1.SaveToRTF(false);
        }
    }
}
