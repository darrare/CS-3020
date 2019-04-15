namespace AuctioneerApp
{
    partial class ClientForm
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
            this.Debugging = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.WarningBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Debugging
            // 
            this.Debugging.Location = new System.Drawing.Point(196, 67);
            this.Debugging.Name = "Debugging";
            this.Debugging.Size = new System.Drawing.Size(399, 20);
            this.Debugging.TabIndex = 0;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(196, 93);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 1;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // WarningBox
            // 
            this.WarningBox.Enabled = false;
            this.WarningBox.Location = new System.Drawing.Point(13, 418);
            this.WarningBox.Name = "WarningBox";
            this.WarningBox.Size = new System.Drawing.Size(775, 20);
            this.WarningBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Highest Bid";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(347, 196);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "0";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarningBox);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Debugging);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Debugging;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.TextBox WarningBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValueLabel;
    }
}