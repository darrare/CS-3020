namespace TicTacToe
{
    partial class Connection
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_MyPublicIP = new System.Windows.Forms.Label();
            this.Label_MyLocalIP = new System.Windows.Forms.Label();
            this.Label_TheirInformation = new System.Windows.Forms.Label();
            this.TextBox_TheirIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_OpenConnection = new System.Windows.Forms.Button();
            this.RichTextBox_Notifications = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Label_MyLocalIP);
            this.panel1.Controls.Add(this.Label_MyPublicIP);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 46);
            this.panel1.TabIndex = 1;
            // 
            // Label_MyPublicIP
            // 
            this.Label_MyPublicIP.AutoSize = true;
            this.Label_MyPublicIP.Location = new System.Drawing.Point(4, 4);
            this.Label_MyPublicIP.Name = "Label_MyPublicIP";
            this.Label_MyPublicIP.Size = new System.Drawing.Size(35, 13);
            this.Label_MyPublicIP.TabIndex = 0;
            this.Label_MyPublicIP.Text = "label2";
            // 
            // Label_MyLocalIP
            // 
            this.Label_MyLocalIP.AutoSize = true;
            this.Label_MyLocalIP.Location = new System.Drawing.Point(3, 26);
            this.Label_MyLocalIP.Name = "Label_MyLocalIP";
            this.Label_MyLocalIP.Size = new System.Drawing.Size(35, 13);
            this.Label_MyLocalIP.TabIndex = 1;
            this.Label_MyLocalIP.Text = "label2";
            // 
            // Label_TheirInformation
            // 
            this.Label_TheirInformation.AutoSize = true;
            this.Label_TheirInformation.Location = new System.Drawing.Point(12, 78);
            this.Label_TheirInformation.Name = "Label_TheirInformation";
            this.Label_TheirInformation.Size = new System.Drawing.Size(86, 13);
            this.Label_TheirInformation.TabIndex = 2;
            this.Label_TheirInformation.Text = "Their Information";
            // 
            // TextBox_TheirIPAddress
            // 
            this.TextBox_TheirIPAddress.Location = new System.Drawing.Point(76, 92);
            this.TextBox_TheirIPAddress.Name = "TextBox_TheirIPAddress";
            this.TextBox_TheirIPAddress.Size = new System.Drawing.Size(136, 20);
            this.TextBox_TheirIPAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address";
            // 
            // Button_OpenConnection
            // 
            this.Button_OpenConnection.Location = new System.Drawing.Point(247, 14);
            this.Button_OpenConnection.Name = "Button_OpenConnection";
            this.Button_OpenConnection.Size = new System.Drawing.Size(167, 23);
            this.Button_OpenConnection.TabIndex = 5;
            this.Button_OpenConnection.Text = "Open Connection";
            this.Button_OpenConnection.UseVisualStyleBackColor = true;
            this.Button_OpenConnection.Click += new System.EventHandler(this.Button_OpenConnection_Click);
            // 
            // RichTextBox_Notifications
            // 
            this.RichTextBox_Notifications.Location = new System.Drawing.Point(247, 43);
            this.RichTextBox_Notifications.Name = "RichTextBox_Notifications";
            this.RichTextBox_Notifications.Size = new System.Drawing.Size(167, 69);
            this.RichTextBox_Notifications.TabIndex = 6;
            this.RichTextBox_Notifications.Text = "";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 124);
            this.Controls.Add(this.RichTextBox_Notifications);
            this.Controls.Add(this.Button_OpenConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_TheirIPAddress);
            this.Controls.Add(this.Label_TheirInformation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Connection";
            this.Text = "Connection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_MyLocalIP;
        private System.Windows.Forms.Label Label_MyPublicIP;
        private System.Windows.Forms.Label Label_TheirInformation;
        private System.Windows.Forms.TextBox TextBox_TheirIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_OpenConnection;
        private System.Windows.Forms.RichTextBox RichTextBox_Notifications;
    }
}