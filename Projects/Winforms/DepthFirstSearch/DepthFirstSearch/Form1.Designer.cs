namespace DepthFirstSearch
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
            this.PictureBox_Map = new System.Windows.Forms.PictureBox();
            this.Button_FindPathInstant = new System.Windows.Forms.Button();
            this.Button_FindPathIteration = new System.Windows.Forms.Button();
            this.Button_RandomizeMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Map
            // 
            this.PictureBox_Map.Location = new System.Drawing.Point(12, 12);
            this.PictureBox_Map.Name = "PictureBox_Map";
            this.PictureBox_Map.Size = new System.Drawing.Size(500, 500);
            this.PictureBox_Map.TabIndex = 0;
            this.PictureBox_Map.TabStop = false;
            // 
            // Button_FindPathInstant
            // 
            this.Button_FindPathInstant.Location = new System.Drawing.Point(519, 13);
            this.Button_FindPathInstant.Name = "Button_FindPathInstant";
            this.Button_FindPathInstant.Size = new System.Drawing.Size(141, 23);
            this.Button_FindPathInstant.TabIndex = 1;
            this.Button_FindPathInstant.Text = "Find Path (Instant)";
            this.Button_FindPathInstant.UseVisualStyleBackColor = true;
            this.Button_FindPathInstant.Click += new System.EventHandler(this.Button_FindPathInstant_Click);
            // 
            // Button_FindPathIteration
            // 
            this.Button_FindPathIteration.Location = new System.Drawing.Point(518, 42);
            this.Button_FindPathIteration.Name = "Button_FindPathIteration";
            this.Button_FindPathIteration.Size = new System.Drawing.Size(141, 23);
            this.Button_FindPathIteration.TabIndex = 2;
            this.Button_FindPathIteration.Text = "Find Path (Iteration)";
            this.Button_FindPathIteration.UseVisualStyleBackColor = true;
            this.Button_FindPathIteration.Click += new System.EventHandler(this.Button_FindPathIteration_Click);
            // 
            // Button_RandomizeMap
            // 
            this.Button_RandomizeMap.Location = new System.Drawing.Point(518, 418);
            this.Button_RandomizeMap.Name = "Button_RandomizeMap";
            this.Button_RandomizeMap.Size = new System.Drawing.Size(141, 23);
            this.Button_RandomizeMap.TabIndex = 3;
            this.Button_RandomizeMap.Text = "Randomize Map";
            this.Button_RandomizeMap.UseVisualStyleBackColor = true;
            this.Button_RandomizeMap.Click += new System.EventHandler(this.Button_RandomizeMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 527);
            this.Controls.Add(this.Button_RandomizeMap);
            this.Controls.Add(this.Button_FindPathIteration);
            this.Controls.Add(this.Button_FindPathInstant);
            this.Controls.Add(this.PictureBox_Map);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Map;
        private System.Windows.Forms.Button Button_FindPathInstant;
        private System.Windows.Forms.Button Button_FindPathIteration;
        private System.Windows.Forms.Button Button_RandomizeMap;
    }
}

