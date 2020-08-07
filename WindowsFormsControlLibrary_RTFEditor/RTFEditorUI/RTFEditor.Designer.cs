namespace RTFEditorUI
{
    partial class RTFEditor
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertImage = new System.Windows.Forms.Button();
            this.RestoreFormat = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.totalResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LaunchRTF = new System.Windows.Forms.Button();
            this.LoadFromRTF = new System.Windows.Forms.Button();
            this.SaveToRTF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InsertImage
            // 
            this.InsertImage.Location = new System.Drawing.Point(735, 135);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(75, 23);
            this.InsertImage.TabIndex = 25;
            this.InsertImage.Text = "InsertImage";
            this.InsertImage.UseVisualStyleBackColor = true;
            this.InsertImage.Click += new System.EventHandler(this.InsertImage_Click);
            // 
            // RestoreFormat
            // 
            this.RestoreFormat.Location = new System.Drawing.Point(735, 547);
            this.RestoreFormat.Name = "RestoreFormat";
            this.RestoreFormat.Size = new System.Drawing.Size(91, 23);
            this.RestoreFormat.TabIndex = 24;
            this.RestoreFormat.Text = "RestoreFormat";
            this.RestoreFormat.UseVisualStyleBackColor = true;
            this.RestoreFormat.Click += new System.EventHandler(this.RestoreFormat_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(812, 72);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(52, 19);
            this.Results.TabIndex = 23;
            this.Results.Text = "Results";
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // totalResult
            // 
            this.totalResult.AutoSize = true;
            this.totalResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResult.Location = new System.Drawing.Point(776, 72);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(0, 19);
            this.totalResult.TabIndex = 22;
            this.totalResult.Click += new System.EventHandler(this.totalResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(735, 44);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(132, 20);
            this.SearchTextBox.TabIndex = 20;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LaunchRTF
            // 
            this.LaunchRTF.Location = new System.Drawing.Point(564, 5);
            this.LaunchRTF.Name = "LaunchRTF";
            this.LaunchRTF.Size = new System.Drawing.Size(82, 38);
            this.LaunchRTF.TabIndex = 19;
            this.LaunchRTF.Text = "LaunchRTFWithWordPad";
            this.LaunchRTF.UseVisualStyleBackColor = true;
            this.LaunchRTF.Click += new System.EventHandler(this.LaunchRTF_Click);
            // 
            // LoadFromRTF
            // 
            this.LoadFromRTF.Location = new System.Drawing.Point(78, 13);
            this.LoadFromRTF.Name = "LoadFromRTF";
            this.LoadFromRTF.Size = new System.Drawing.Size(89, 23);
            this.LoadFromRTF.TabIndex = 18;
            this.LoadFromRTF.Text = "LoadFromRTF";
            this.LoadFromRTF.UseVisualStyleBackColor = true;
            this.LoadFromRTF.Click += new System.EventHandler(this.LoadFromRTF_Click);
            // 
            // SaveToRTF
            // 
            this.SaveToRTF.Location = new System.Drawing.Point(328, 13);
            this.SaveToRTF.Name = "SaveToRTF";
            this.SaveToRTF.Size = new System.Drawing.Size(75, 23);
            this.SaveToRTF.TabIndex = 17;
            this.SaveToRTF.Text = "SaveToRTF";
            this.SaveToRTF.UseVisualStyleBackColor = true;
            this.SaveToRTF.Click += new System.EventHandler(this.SaveToRTF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 524);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // RTFEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InsertImage);
            this.Controls.Add(this.RestoreFormat);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.LaunchRTF);
            this.Controls.Add(this.LoadFromRTF);
            this.Controls.Add(this.SaveToRTF);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RTFEditor";
            this.Size = new System.Drawing.Size(876, 582);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertImage;
        private System.Windows.Forms.Button RestoreFormat;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label totalResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button LaunchRTF;
        private System.Windows.Forms.Button LoadFromRTF;
        private System.Windows.Forms.Button SaveToRTF;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
