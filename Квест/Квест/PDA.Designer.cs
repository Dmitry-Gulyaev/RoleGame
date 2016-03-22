namespace Квест
{
    partial class PDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDA));
            this.OpenMaps = new System.Windows.Forms.Button();
            this.TaksList = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenMaps
            // 
            this.OpenMaps.Location = new System.Drawing.Point(107, 34);
            this.OpenMaps.Name = "OpenMaps";
            this.OpenMaps.Size = new System.Drawing.Size(217, 23);
            this.OpenMaps.TabIndex = 0;
            this.OpenMaps.Text = "Открыть карту";
            this.OpenMaps.UseVisualStyleBackColor = true;
            this.OpenMaps.Click += new System.EventHandler(this.OpenMaps_Click);
            // 
            // TaksList
            // 
            this.TaksList.Location = new System.Drawing.Point(107, 63);
            this.TaksList.Name = "TaksList";
            this.TaksList.Size = new System.Drawing.Size(217, 23);
            this.TaksList.TabIndex = 1;
            this.TaksList.Text = "Список заданий";
            this.TaksList.UseVisualStyleBackColor = true;
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(107, 92);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(217, 24);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "Статистика";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Энциклопедия сталкера";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.TaksList);
            this.Controls.Add(this.OpenMaps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDA";
            this.Text = "Карманный компьютер";
            this.Load += new System.EventHandler(this.PDA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenMaps;
        private System.Windows.Forms.Button TaksList;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Button button1;
    }
}