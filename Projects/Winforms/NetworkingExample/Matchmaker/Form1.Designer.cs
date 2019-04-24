namespace Matchmaker
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
            this.Button_StartMatchmaker = new System.Windows.Forms.Button();
            this.Button_FindMatch = new System.Windows.Forms.Button();
            this.RichTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.Label_LocalIP = new System.Windows.Forms.Label();
            this.Button_SendPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartMatchmaker
            // 
            this.Button_StartMatchmaker.Location = new System.Drawing.Point(13, 13);
            this.Button_StartMatchmaker.Name = "Button_StartMatchmaker";
            this.Button_StartMatchmaker.Size = new System.Drawing.Size(151, 23);
            this.Button_StartMatchmaker.TabIndex = 0;
            this.Button_StartMatchmaker.Text = "Start Matchmaker";
            this.Button_StartMatchmaker.UseVisualStyleBackColor = true;
            this.Button_StartMatchmaker.Click += new System.EventHandler(this.Button_StartMatchmaker_Click);
            // 
            // Button_FindMatch
            // 
            this.Button_FindMatch.Location = new System.Drawing.Point(12, 42);
            this.Button_FindMatch.Name = "Button_FindMatch";
            this.Button_FindMatch.Size = new System.Drawing.Size(151, 23);
            this.Button_FindMatch.TabIndex = 1;
            this.Button_FindMatch.Text = "FindMatch";
            this.Button_FindMatch.UseVisualStyleBackColor = true;
            this.Button_FindMatch.Click += new System.EventHandler(this.Button_FindMatch_Click);
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Enabled = false;
            this.RichTextBox_Message.Location = new System.Drawing.Point(12, 100);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(151, 110);
            this.RichTextBox_Message.TabIndex = 2;
            this.RichTextBox_Message.Text = "";
            // 
            // Label_LocalIP
            // 
            this.Label_LocalIP.AutoSize = true;
            this.Label_LocalIP.Location = new System.Drawing.Point(12, 213);
            this.Label_LocalIP.Name = "Label_LocalIP";
            this.Label_LocalIP.Size = new System.Drawing.Size(0, 13);
            this.Label_LocalIP.TabIndex = 3;
            // 
            // Button_SendPing
            // 
            this.Button_SendPing.Location = new System.Drawing.Point(12, 71);
            this.Button_SendPing.Name = "Button_SendPing";
            this.Button_SendPing.Size = new System.Drawing.Size(151, 23);
            this.Button_SendPing.TabIndex = 4;
            this.Button_SendPing.Text = "Send Ping";
            this.Button_SendPing.UseVisualStyleBackColor = true;
            this.Button_SendPing.Click += new System.EventHandler(this.Button_SendPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 252);
            this.Controls.Add(this.Button_SendPing);
            this.Controls.Add(this.Label_LocalIP);
            this.Controls.Add(this.RichTextBox_Message);
            this.Controls.Add(this.Button_FindMatch);
            this.Controls.Add(this.Button_StartMatchmaker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_StartMatchmaker;
        private System.Windows.Forms.Button Button_FindMatch;
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
        private System.Windows.Forms.Label Label_LocalIP;
        private System.Windows.Forms.Button Button_SendPing;
    }
}

