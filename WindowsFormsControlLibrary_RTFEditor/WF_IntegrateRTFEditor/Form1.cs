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
            rtfEditor1.LoadFromRTF_Click(new object(), new EventArgs());

            string curRTBContent = rtfEditor1.getRichTextBoxContent();
            richTextBox1.Rtf = curRTBContent;
        }
    }
}
