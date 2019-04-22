namespace AsyncPeopleManager
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
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Button_Import = new System.Windows.Forms.Button();
            this.Button_Export = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.Size = new System.Drawing.Size(657, 397);
            this.MainDataGrid.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 415);
            this.ProgressBar.Maximum = 1000;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(657, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 1;
            // 
            // Button_Import
            // 
            this.Button_Import.Location = new System.Drawing.Point(677, 13);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Size = new System.Drawing.Size(111, 23);
            this.Button_Import.TabIndex = 2;
            this.Button_Import.Text = "Import";
            this.Button_Import.UseVisualStyleBackColor = true;
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // Button_Export
            // 
            this.Button_Export.Location = new System.Drawing.Point(677, 43);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(111, 23);
            this.Button_Export.TabIndex = 3;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainDataGrid);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 397);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Button_Import);
            this.Controls.Add(this.ProgressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button Button_Import;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Panel panel1;
    }
}

