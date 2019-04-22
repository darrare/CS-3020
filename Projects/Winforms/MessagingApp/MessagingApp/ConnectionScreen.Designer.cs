namespace MessagingApp
{
    partial class ConnectionScreen
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
            this.Label_MyIpAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_MyPort = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_TheirIPAddress = new System.Windows.Forms.TextBox();
            this.TextBox_TheirPort = new System.Windows.Forms.TextBox();
            this.Button_FindConnection = new System.Windows.Forms.Button();
            this.Label_MySubnetIP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_MyIpAddress
            // 
            this.Label_MyIpAddress.AutoSize = true;
            this.Label_MyIpAddress.Location = new System.Drawing.Point(3, 9);
            this.Label_MyIpAddress.Name = "Label_MyIpAddress";
            this.Label_MyIpAddress.Size = new System.Drawing.Size(61, 13);
            this.Label_MyIpAddress.TabIndex = 0;
            this.Label_MyIpAddress.Text = "IP Address:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Label_MySubnetIP);
            this.panel1.Controls.Add(this.Label_MyPort);
            this.panel1.Controls.Add(this.Label_MyIpAddress);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 68);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your information";
            // 
            // Label_MyPort
            // 
            this.Label_MyPort.AutoSize = true;
            this.Label_MyPort.Location = new System.Drawing.Point(35, 44);
            this.Label_MyPort.Name = "Label_MyPort";
            this.Label_MyPort.Size = new System.Drawing.Size(29, 13);
            this.Label_MyPort.TabIndex = 1;
            this.Label_MyPort.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Their information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Port:";
            // 
            // TextBox_TheirIPAddress
            // 
            this.TextBox_TheirIPAddress.Location = new System.Drawing.Point(301, 24);
            this.TextBox_TheirIPAddress.Name = "TextBox_TheirIPAddress";
            this.TextBox_TheirIPAddress.Size = new System.Drawing.Size(187, 20);
            this.TextBox_TheirIPAddress.TabIndex = 6;
            // 
            // TextBox_TheirPort
            // 
            this.TextBox_TheirPort.Location = new System.Drawing.Point(301, 50);
            this.TextBox_TheirPort.Name = "TextBox_TheirPort";
            this.TextBox_TheirPort.Size = new System.Drawing.Size(187, 20);
            this.TextBox_TheirPort.TabIndex = 7;
            // 
            // Button_FindConnection
            // 
            this.Button_FindConnection.Location = new System.Drawing.Point(301, 83);
            this.Button_FindConnection.Name = "Button_FindConnection";
            this.Button_FindConnection.Size = new System.Drawing.Size(187, 23);
            this.Button_FindConnection.TabIndex = 8;
            this.Button_FindConnection.Text = "Find Connection";
            this.Button_FindConnection.UseVisualStyleBackColor = true;
            this.Button_FindConnection.Click += new System.EventHandler(this.Button_FindConnection_Click);
            // 
            // Label_MySubnetIP
            // 
            this.Label_MySubnetIP.AutoSize = true;
            this.Label_MySubnetIP.Location = new System.Drawing.Point(7, 26);
            this.Label_MySubnetIP.Name = "Label_MySubnetIP";
            this.Label_MySubnetIP.Size = new System.Drawing.Size(57, 13);
            this.Label_MySubnetIP.TabIndex = 2;
            this.Label_MySubnetIP.Text = "Subnet IP:";
            // 
            // ConnectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 118);
            this.Controls.Add(this.Button_FindConnection);
            this.Controls.Add(this.TextBox_TheirPort);
            this.Controls.Add(this.TextBox_TheirIPAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ConnectionScreen";
            this.Text = "ConnectionScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_MyIpAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_MyPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_TheirIPAddress;
        private System.Windows.Forms.TextBox TextBox_TheirPort;
        private System.Windows.Forms.Button Button_FindConnection;
        private System.Windows.Forms.Label Label_MySubnetIP;
    }
}