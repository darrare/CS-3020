namespace HostClient
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
            this.Button_StartListener = new System.Windows.Forms.Button();
            this.Button_SendPing = new System.Windows.Forms.Button();
            this.RichTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.Label_LocalIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_StartListener
            // 
            this.Button_StartListener.Location = new System.Drawing.Point(13, 13);
            this.Button_StartListener.Name = "Button_StartListener";
            this.Button_StartListener.Size = new System.Drawing.Size(151, 23);
            this.Button_StartListener.TabIndex = 0;
            this.Button_StartListener.Text = "Start Listener";
            this.Button_StartListener.UseVisualStyleBackColor = true;
            this.Button_StartListener.Click += new System.EventHandler(this.Button_StartListener_Click);
            // 
            // Button_SendPing
            // 
            this.Button_SendPing.Location = new System.Drawing.Point(12, 42);
            this.Button_SendPing.Name = "Button_SendPing";
            this.Button_SendPing.Size = new System.Drawing.Size(151, 23);
            this.Button_SendPing.TabIndex = 1;
            this.Button_SendPing.Text = "Send Ping";
            this.Button_SendPing.UseVisualStyleBackColor = true;
            this.Button_SendPing.Click += new System.EventHandler(this.Button_SendPing_Click);
            // 
            // RichTextBox_Message
            // 
            this.RichTextBox_Message.Enabled = false;
            this.RichTextBox_Message.Location = new System.Drawing.Point(12, 72);
            this.RichTextBox_Message.Name = "RichTextBox_Message";
            this.RichTextBox_Message.Size = new System.Drawing.Size(151, 138);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 252);
            this.Controls.Add(this.Label_LocalIP);
            this.Controls.Add(this.RichTextBox_Message);
            this.Controls.Add(this.Button_SendPing);
            this.Controls.Add(this.Button_StartListener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_StartListener;
        private System.Windows.Forms.Button Button_SendPing;
        private System.Windows.Forms.RichTextBox RichTextBox_Message;
        private System.Windows.Forms.Label Label_LocalIP;
    }
}

