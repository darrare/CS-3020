namespace MessagingApp
{
    partial class Messenger
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
            this.RichTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox_Main
            // 
            this.RichTextBox_Main.Enabled = false;
            this.RichTextBox_Main.Location = new System.Drawing.Point(13, 13);
            this.RichTextBox_Main.Name = "RichTextBox_Main";
            this.RichTextBox_Main.Size = new System.Drawing.Size(775, 378);
            this.RichTextBox_Main.TabIndex = 0;
            this.RichTextBox_Main.Text = "";
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(13, 398);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(694, 20);
            this.TextBox_Input.TabIndex = 1;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(713, 396);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 2;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.TextBox_Input);
            this.Controls.Add(this.RichTextBox_Main);
            this.Name = "Messenger";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_Main;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.Button Button_Send;
    }
}

