namespace AuctioneerApp
{
    partial class HostForm
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
            this.Host_ClientListBox = new System.Windows.Forms.ListBox();
            this.Debugging = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Host_ClientListBox
            // 
            this.Host_ClientListBox.FormattingEnabled = true;
            this.Host_ClientListBox.Location = new System.Drawing.Point(668, 12);
            this.Host_ClientListBox.Name = "Host_ClientListBox";
            this.Host_ClientListBox.Size = new System.Drawing.Size(120, 420);
            this.Host_ClientListBox.TabIndex = 0;
            // 
            // Debugging
            // 
            this.Debugging.Location = new System.Drawing.Point(12, 412);
            this.Debugging.Name = "Debugging";
            this.Debugging.Size = new System.Drawing.Size(650, 20);
            this.Debugging.TabIndex = 1;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Debugging);
            this.Controls.Add(this.Host_ClientListBox);
            this.Name = "HostForm";
            this.Text = "HostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Host_ClientListBox;
        private System.Windows.Forms.TextBox Debugging;
    }
}