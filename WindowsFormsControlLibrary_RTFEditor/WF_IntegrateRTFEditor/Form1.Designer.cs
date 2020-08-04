namespace WF_IntegrateRTFEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtfEditor1 = new RTFEditorUI.RTFEditor();
            this.SuspendLayout();
            // 
            // rtfEditor1
            // 
            this.rtfEditor1.Location = new System.Drawing.Point(12, 12);
            this.rtfEditor1.Name = "rtfEditor1";
            this.rtfEditor1.Size = new System.Drawing.Size(922, 647);
            this.rtfEditor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 816);
            this.Controls.Add(this.rtfEditor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RTFEditorUI.RTFEditor rtfEditor1;
    }
}

