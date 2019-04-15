namespace AuctioneerApp
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
            this.Button_Host = new System.Windows.Forms.Button();
            this.Button_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Host
            // 
            this.Button_Host.Location = new System.Drawing.Point(12, 12);
            this.Button_Host.Name = "Button_Host";
            this.Button_Host.Size = new System.Drawing.Size(75, 23);
            this.Button_Host.TabIndex = 0;
            this.Button_Host.Text = "Host";
            this.Button_Host.UseVisualStyleBackColor = true;
            this.Button_Host.Click += new System.EventHandler(this.Button_Host_Click);
            // 
            // Button_Client
            // 
            this.Button_Client.Location = new System.Drawing.Point(93, 12);
            this.Button_Client.Name = "Button_Client";
            this.Button_Client.Size = new System.Drawing.Size(75, 23);
            this.Button_Client.TabIndex = 1;
            this.Button_Client.Text = "Client";
            this.Button_Client.UseVisualStyleBackColor = true;
            this.Button_Client.Click += new System.EventHandler(this.Button_Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 52);
            this.Controls.Add(this.Button_Client);
            this.Controls.Add(this.Button_Host);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Host;
        private System.Windows.Forms.Button Button_Client;
    }
}

