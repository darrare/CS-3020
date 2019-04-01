namespace Toolbox
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
            this.DoSomethingButton = new System.Windows.Forms.Button();
            this.Failsafe = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SecretCodeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DoSomethingButton
            // 
            this.DoSomethingButton.Location = new System.Drawing.Point(13, 28);
            this.DoSomethingButton.Name = "DoSomethingButton";
            this.DoSomethingButton.Size = new System.Drawing.Size(125, 23);
            this.DoSomethingButton.TabIndex = 0;
            this.DoSomethingButton.Text = "Do Something";
            this.DoSomethingButton.UseVisualStyleBackColor = true;
            this.DoSomethingButton.Click += new System.EventHandler(this.DoSomethingButton_Click);
            // 
            // Failsafe
            // 
            this.Failsafe.AutoSize = true;
            this.Failsafe.Location = new System.Drawing.Point(144, 32);
            this.Failsafe.Name = "Failsafe";
            this.Failsafe.Size = new System.Drawing.Size(62, 17);
            this.Failsafe.TabIndex = 1;
            this.Failsafe.Text = "Failsafe";
            this.Failsafe.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(212, 31);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checkbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(13, 100);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(399, 223);
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            // 
            // SecretCodeTextBox
            // 
            this.SecretCodeTextBox.Location = new System.Drawing.Point(13, 58);
            this.SecretCodeTextBox.Name = "SecretCodeTextBox";
            this.SecretCodeTextBox.Size = new System.Drawing.Size(399, 20);
            this.SecretCodeTextBox.TabIndex = 7;
            this.SecretCodeTextBox.TextChanged += new System.EventHandler(this.SecretCodeTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 335);
            this.Controls.Add(this.SecretCodeTextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Failsafe);
            this.Controls.Add(this.DoSomethingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoSomethingButton;
        private System.Windows.Forms.CheckBox Failsafe;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox SecretCodeTextBox;
    }
}

