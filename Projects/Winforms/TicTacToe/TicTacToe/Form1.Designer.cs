namespace TicTacToe
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
            this.Button00 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button21 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button01 = new System.Windows.Forms.Button();
            this.Button22 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button02 = new System.Windows.Forms.Button();
            this.TextBox_Status = new System.Windows.Forms.TextBox();
            this.Button_FindNewOpponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button00
            // 
            this.Button00.Location = new System.Drawing.Point(13, 13);
            this.Button00.Name = "Button00";
            this.Button00.Size = new System.Drawing.Size(65, 65);
            this.Button00.TabIndex = 0;
            this.Button00.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(84, 13);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(65, 65);
            this.Button10.TabIndex = 1;
            this.Button10.UseVisualStyleBackColor = true;
            // 
            // Button20
            // 
            this.Button20.Location = new System.Drawing.Point(155, 13);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(65, 65);
            this.Button20.TabIndex = 2;
            this.Button20.UseVisualStyleBackColor = true;
            // 
            // Button21
            // 
            this.Button21.Location = new System.Drawing.Point(155, 84);
            this.Button21.Name = "Button21";
            this.Button21.Size = new System.Drawing.Size(65, 65);
            this.Button21.TabIndex = 5;
            this.Button21.UseVisualStyleBackColor = true;
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(84, 84);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(65, 65);
            this.Button11.TabIndex = 4;
            this.Button11.UseVisualStyleBackColor = true;
            // 
            // Button01
            // 
            this.Button01.Location = new System.Drawing.Point(13, 84);
            this.Button01.Name = "Button01";
            this.Button01.Size = new System.Drawing.Size(65, 65);
            this.Button01.TabIndex = 3;
            this.Button01.UseVisualStyleBackColor = true;
            // 
            // Button22
            // 
            this.Button22.Location = new System.Drawing.Point(154, 155);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(65, 65);
            this.Button22.TabIndex = 8;
            this.Button22.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            this.Button12.Location = new System.Drawing.Point(83, 155);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(65, 65);
            this.Button12.TabIndex = 7;
            this.Button12.UseVisualStyleBackColor = true;
            // 
            // Button02
            // 
            this.Button02.Location = new System.Drawing.Point(12, 155);
            this.Button02.Name = "Button02";
            this.Button02.Size = new System.Drawing.Size(65, 65);
            this.Button02.TabIndex = 6;
            this.Button02.UseVisualStyleBackColor = true;
            // 
            // TextBox_Status
            // 
            this.TextBox_Status.Enabled = false;
            this.TextBox_Status.Location = new System.Drawing.Point(12, 226);
            this.TextBox_Status.Name = "TextBox_Status";
            this.TextBox_Status.Size = new System.Drawing.Size(207, 20);
            this.TextBox_Status.TabIndex = 9;
            // 
            // Button_FindNewOpponent
            // 
            this.Button_FindNewOpponent.Location = new System.Drawing.Point(13, 252);
            this.Button_FindNewOpponent.Name = "Button_FindNewOpponent";
            this.Button_FindNewOpponent.Size = new System.Drawing.Size(207, 23);
            this.Button_FindNewOpponent.TabIndex = 10;
            this.Button_FindNewOpponent.Text = "Find New Opponent";
            this.Button_FindNewOpponent.UseVisualStyleBackColor = true;
            this.Button_FindNewOpponent.Click += new System.EventHandler(this.Button_FindNewOpponent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 286);
            this.Controls.Add(this.Button_FindNewOpponent);
            this.Controls.Add(this.TextBox_Status);
            this.Controls.Add(this.Button22);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button02);
            this.Controls.Add(this.Button21);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.Button01);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button00;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Button Button21;
        private System.Windows.Forms.Button Button11;
        private System.Windows.Forms.Button Button01;
        private System.Windows.Forms.Button Button22;
        private System.Windows.Forms.Button Button12;
        private System.Windows.Forms.Button Button02;
        private System.Windows.Forms.TextBox TextBox_Status;
        private System.Windows.Forms.Button Button_FindNewOpponent;
    }
}

