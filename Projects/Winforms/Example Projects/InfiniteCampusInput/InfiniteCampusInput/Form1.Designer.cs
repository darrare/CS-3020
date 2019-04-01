namespace InfiniteCampusInput
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
            this.SelectFile = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.NumColumnsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LatencyDelayText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputColumnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InputRangePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(264, 180);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 23);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(345, 180);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Enabled = false;
            this.MessageBox.Location = new System.Drawing.Point(264, 77);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(328, 97);
            this.MessageBox.TabIndex = 2;
            // 
            // NumColumnsText
            // 
            this.NumColumnsText.Location = new System.Drawing.Point(264, 25);
            this.NumColumnsText.Name = "NumColumnsText";
            this.NumColumnsText.Size = new System.Drawing.Size(42, 20);
            this.NumColumnsText.TabIndex = 5;
            this.NumColumnsText.TextChanged += new System.EventHandler(this.NumColumnsText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of columns to input";
            // 
            // LatencyDelayText
            // 
            this.LatencyDelayText.Location = new System.Drawing.Point(264, 51);
            this.LatencyDelayText.Name = "LatencyDelayText";
            this.LatencyDelayText.Size = new System.Drawing.Size(42, 20);
            this.LatencyDelayText.TabIndex = 9;
            this.LatencyDelayText.TextChanged += new System.EventHandler(this.LatencyDelayText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Latency delay (in millisections. Time between key presses)";
            // 
            // OutputColumnPanel
            // 
            this.OutputColumnPanel.Location = new System.Drawing.Point(12, 25);
            this.OutputColumnPanel.Name = "OutputColumnPanel";
            this.OutputColumnPanel.Size = new System.Drawing.Size(111, 397);
            this.OutputColumnPanel.TabIndex = 14;
            // 
            // InputRangePanel
            // 
            this.InputRangePanel.Location = new System.Drawing.Point(129, 25);
            this.InputRangePanel.Name = "InputRangePanel";
            this.InputRangePanel.Size = new System.Drawing.Size(129, 397);
            this.InputRangePanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Output column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input Range (\"D7-D21\" format)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputRangePanel);
            this.Controls.Add(this.OutputColumnPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LatencyDelayText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumColumnsText);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SelectFile);
            this.Name = "Form1";
            this.Text = "Infinite Campus Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.TextBox NumColumnsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LatencyDelayText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel OutputColumnPanel;
        private System.Windows.Forms.FlowLayoutPanel InputRangePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

