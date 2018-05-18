namespace FtpApp
{
    partial class FormMain
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lTotal = new System.Windows.Forms.Label();
            this.lTotalValue = new System.Windows.Forms.Label();
            this.lCopiedValue = new System.Windows.Forms.Label();
            this.lCopied = new System.Windows.Forms.Label();
            this.lEstimatedValue = new System.Windows.Forms.Label();
            this.lEstimated = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lRateValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(951, 16);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Download";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(97, 18);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(844, 22);
            this.txtFile.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 144);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(925, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(19, 181);
            this.lTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(85, 17);
            this.lTotal.TabIndex = 3;
            this.lTotal.Text = "File size (b):";
            // 
            // lTotalValue
            // 
            this.lTotalValue.AutoSize = true;
            this.lTotalValue.Location = new System.Drawing.Point(176, 181);
            this.lTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotalValue.Name = "lTotalValue";
            this.lTotalValue.Size = new System.Drawing.Size(16, 17);
            this.lTotalValue.TabIndex = 4;
            this.lTotalValue.Text = "0";
            // 
            // lCopiedValue
            // 
            this.lCopiedValue.AutoSize = true;
            this.lCopiedValue.Location = new System.Drawing.Point(176, 210);
            this.lCopiedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCopiedValue.Name = "lCopiedValue";
            this.lCopiedValue.Size = new System.Drawing.Size(16, 17);
            this.lCopiedValue.TabIndex = 6;
            this.lCopiedValue.Text = "0";
            // 
            // lCopied
            // 
            this.lCopied.AutoSize = true;
            this.lCopied.Location = new System.Drawing.Point(19, 210);
            this.lCopied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCopied.Name = "lCopied";
            this.lCopied.Size = new System.Drawing.Size(112, 17);
            this.lCopied.TabIndex = 5;
            this.lCopied.Text = "Downloaded (b):";
            // 
            // lEstimatedValue
            // 
            this.lEstimatedValue.AutoSize = true;
            this.lEstimatedValue.Location = new System.Drawing.Point(176, 242);
            this.lEstimatedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEstimatedValue.Name = "lEstimatedValue";
            this.lEstimatedValue.Size = new System.Drawing.Size(16, 17);
            this.lEstimatedValue.TabIndex = 8;
            this.lEstimatedValue.Text = "0";
            // 
            // lEstimated
            // 
            this.lEstimated.AutoSize = true;
            this.lEstimated.Location = new System.Drawing.Point(17, 242);
            this.lEstimated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEstimated.Name = "lEstimated";
            this.lEstimated.Size = new System.Drawing.Size(148, 17);
            this.lEstimated.TabIndex = 7;
            this.lEstimated.Text = "Estimated time left (s):";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(97, 70);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(844, 22);
            this.txtOutput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Load from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save to:";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(951, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(952, 65);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(100, 28);
            this.btnOutput.TabIndex = 13;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lRateValue
            // 
            this.lRateValue.AutoSize = true;
            this.lRateValue.Location = new System.Drawing.Point(176, 276);
            this.lRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRateValue.Name = "lRateValue";
            this.lRateValue.Size = new System.Drawing.Size(16, 17);
            this.lRateValue.TabIndex = 15;
            this.lRateValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Transfer Rate (b/s)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 337);
            this.Controls.Add(this.lRateValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lEstimatedValue);
            this.Controls.Add(this.lEstimated);
            this.Controls.Add(this.lCopiedValue);
            this.Controls.Add(this.lCopied);
            this.Controls.Add(this.lTotalValue);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Ftp downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lTotalValue;
        private System.Windows.Forms.Label lCopiedValue;
        private System.Windows.Forms.Label lCopied;
        private System.Windows.Forms.Label lEstimatedValue;
        private System.Windows.Forms.Label lEstimated;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lRateValue;
        private System.Windows.Forms.Label label4;
    }
}

