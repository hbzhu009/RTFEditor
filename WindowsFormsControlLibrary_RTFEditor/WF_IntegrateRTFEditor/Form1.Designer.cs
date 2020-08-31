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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MergeRTF = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CheckDelta = new System.Windows.Forms.Button();
            this.textBox_NewText = new System.Windows.Forms.TextBox();
            this.AppendText = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.rtfEditor1 = new RTFEditorUI.RTFEditor();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_MergeRTF);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Controls.Add(this.CheckDelta);
            this.groupBox1.Controls.Add(this.textBox_NewText);
            this.groupBox1.Controls.Add(this.AppendText);
            this.groupBox1.Controls.Add(this.Reload);
            this.groupBox1.Controls.Add(this.Load);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Location = new System.Drawing.Point(908, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 440);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test func";
            // 
            // btn_MergeRTF
            // 
            this.btn_MergeRTF.Location = new System.Drawing.Point(10, 374);
            this.btn_MergeRTF.Name = "btn_MergeRTF";
            this.btn_MergeRTF.Size = new System.Drawing.Size(75, 23);
            this.btn_MergeRTF.TabIndex = 11;
            this.btn_MergeRTF.Text = "MergeRTF";
            this.btn_MergeRTF.UseVisualStyleBackColor = true;
            this.btn_MergeRTF.Click += new System.EventHandler(this.btn_MergeRTF_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 320);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(58, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "NoChange";
            // 
            // CheckDelta
            // 
            this.CheckDelta.Location = new System.Drawing.Point(7, 290);
            this.CheckDelta.Name = "CheckDelta";
            this.CheckDelta.Size = new System.Drawing.Size(75, 23);
            this.CheckDelta.TabIndex = 9;
            this.CheckDelta.Text = "CheckDelta";
            this.CheckDelta.UseVisualStyleBackColor = true;
            this.CheckDelta.Click += new System.EventHandler(this.CheckDelta_Click);
            // 
            // textBox_NewText
            // 
            this.textBox_NewText.Location = new System.Drawing.Point(7, 208);
            this.textBox_NewText.Name = "textBox_NewText";
            this.textBox_NewText.Size = new System.Drawing.Size(113, 20);
            this.textBox_NewText.TabIndex = 8;
            // 
            // AppendText
            // 
            this.AppendText.Location = new System.Drawing.Point(32, 234);
            this.AppendText.Name = "AppendText";
            this.AppendText.Size = new System.Drawing.Size(75, 23);
            this.AppendText.TabIndex = 7;
            this.AppendText.Text = "AppendText";
            this.AppendText.UseVisualStyleBackColor = true;
            this.AppendText.Click += new System.EventHandler(this.AppendText_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(45, 163);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(75, 23);
            this.Reload.TabIndex = 6;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(45, 57);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(45, 86);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // rtfEditor1
            // 
            this.rtfEditor1.Location = new System.Drawing.Point(3, 6);
            this.rtfEditor1.Name = "rtfEditor1";
            this.rtfEditor1.Size = new System.Drawing.Size(876, 582);
            this.rtfEditor1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save_NoSign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtfEditor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RTFEditorUI.RTFEditor rtfEditor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button AppendText;
        private System.Windows.Forms.TextBox textBox_NewText;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button CheckDelta;
        private System.Windows.Forms.Button btn_MergeRTF;
        private System.Windows.Forms.Button button1;
    }
}

