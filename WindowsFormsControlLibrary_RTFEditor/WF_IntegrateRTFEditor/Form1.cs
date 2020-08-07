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
            rtfEditor1.RTFpath = @"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf";
            rtfEditor1.LoadFromRTF();           
            
            //richTextBox2.Rtf = curRTBContent;
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            rtfEditor1.userName = "CognexAdministrator";
            rtfEditor1.strVersion = "3.1.5.0";
            rtfEditor1.SaveToRTF();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            rtfEditor1.RTFpath = @"C:\Work\MachineVision\Github\RTFEditor\WindowsFormsControlLibrary_RTFEditor\Figures\temp.rtf";
            rtfEditor1.LoadFromRTF();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            string curRTBContent = rtfEditor1.getRichTextBoxContent();
            rtfEditor1.richTextBox.Clear();
            rtfEditor1.richTextBox.Rtf = curRTBContent;
        }
    }
}
