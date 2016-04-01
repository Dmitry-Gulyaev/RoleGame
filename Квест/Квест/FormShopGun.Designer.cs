namespace Квест
{
    partial class FormShopGun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShopGun));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PDAButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.InventoryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LabelLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LabelHeal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.LabelMoney = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.toolStripSeparator1,
            this.PDAButton,
            this.toolStripSeparator2,
            this.InventoryButton,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.LabelLevel,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.LabelHeal,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.LabelMoney});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PDAButton
            // 
            this.PDAButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PDAButton.Image = ((System.Drawing.Image)(resources.GetObject("PDAButton.Image")));
            this.PDAButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PDAButton.Name = "PDAButton";
            this.PDAButton.Size = new System.Drawing.Size(36, 22);
            this.PDAButton.Text = "ПДА";
            this.PDAButton.Click += new System.EventHandler(this.PDAButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // InventoryButton
            // 
            this.InventoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("InventoryButton.Image")));
            this.InventoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(70, 22);
            this.InventoryButton.Text = "Инвентарь";
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "Уровень:";
            // 
            // LabelLevel
            // 
            this.LabelLevel.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLevel.ForeColor = System.Drawing.Color.Lime;
            this.LabelLevel.ImageTransparentColor = System.Drawing.Color.White;
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(35, 22);
            this.LabelLevel.Text = "1(0)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel2.Text = "Здоровье:";
            // 
            // LabelHeal
            // 
            this.LabelHeal.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeal.ForeColor = System.Drawing.Color.Red;
            this.LabelHeal.Name = "LabelHeal";
            this.LabelHeal.Size = new System.Drawing.Size(54, 22);
            this.LabelHeal.Text = "100 HP";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel3.Text = "Денег:";
            // 
            // LabelMoney
            // 
            this.LabelMoney.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMoney.ForeColor = System.Drawing.Color.Goldenrod;
            this.LabelMoney.Name = "LabelMoney";
            this.LabelMoney.Size = new System.Drawing.Size(67, 22);
            this.LabelMoney.Text = "1000 руб";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // FormShopGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShopGun";
            this.Text = "Оружие на ветрине";
            this.Load += new System.EventHandler(this.FormShopGun_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PDAButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton InventoryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel LabelLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel LabelHeal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel LabelMoney;
        private System.Windows.Forms.Label label1;
    }
}