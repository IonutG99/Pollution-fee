namespace NormaPoluare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Norma = new System.Windows.Forms.ComboBox();
            this.AnFabricatie = new System.Windows.Forms.ComboBox();
            this.EmisiaCO2 = new System.Windows.Forms.TextBox();
            this.ValoareTaxa = new System.Windows.Forms.TextBox();
            this.CapacitateCilindrica = new System.Windows.Forms.TextBox();
            this.CalculeazaTaxa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taxaPoluareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Norma de poluare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacitate cilindrica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emisie de CO2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anul de fabricatie";
            // 
            // Norma
            // 
            this.Norma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Norma.FormattingEnabled = true;
            this.Norma.Location = new System.Drawing.Point(432, 36);
            this.Norma.Name = "Norma";
            this.Norma.Size = new System.Drawing.Size(121, 28);
            this.Norma.TabIndex = 5;
            this.Norma.SelectedIndexChanged += new System.EventHandler(this.Norma_SelectedIndexChanged);
            // 
            // AnFabricatie
            // 
            this.AnFabricatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnFabricatie.FormattingEnabled = true;
            this.AnFabricatie.Location = new System.Drawing.Point(432, 189);
            this.AnFabricatie.Name = "AnFabricatie";
            this.AnFabricatie.Size = new System.Drawing.Size(121, 28);
            this.AnFabricatie.TabIndex = 6;
            // 
            // EmisiaCO2
            // 
            this.EmisiaCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmisiaCO2.Location = new System.Drawing.Point(432, 82);
            this.EmisiaCO2.Multiline = true;
            this.EmisiaCO2.Name = "EmisiaCO2";
            this.EmisiaCO2.Size = new System.Drawing.Size(121, 35);
            this.EmisiaCO2.TabIndex = 7;
            this.EmisiaCO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValoareTaxa
            // 
            this.ValoareTaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValoareTaxa.BackColor = System.Drawing.SystemColors.Window;
            this.ValoareTaxa.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoareTaxa.ForeColor = System.Drawing.Color.Red;
            this.ValoareTaxa.Location = new System.Drawing.Point(579, 131);
            this.ValoareTaxa.Multiline = true;
            this.ValoareTaxa.Name = "ValoareTaxa";
            this.ValoareTaxa.Size = new System.Drawing.Size(202, 91);
            this.ValoareTaxa.TabIndex = 9;
            this.ValoareTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CapacitateCilindrica
            // 
            this.CapacitateCilindrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacitateCilindrica.Location = new System.Drawing.Point(432, 133);
            this.CapacitateCilindrica.Multiline = true;
            this.CapacitateCilindrica.Name = "CapacitateCilindrica";
            this.CapacitateCilindrica.Size = new System.Drawing.Size(121, 35);
            this.CapacitateCilindrica.TabIndex = 10;
            this.CapacitateCilindrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculeazaTaxa
            // 
            this.CalculeazaTaxa.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculeazaTaxa.ForeColor = System.Drawing.Color.Blue;
            this.CalculeazaTaxa.Location = new System.Drawing.Point(579, 50);
            this.CalculeazaTaxa.Name = "CalculeazaTaxa";
            this.CalculeazaTaxa.Size = new System.Drawing.Size(200, 51);
            this.CalculeazaTaxa.TabIndex = 11;
            this.CalculeazaTaxa.Text = "Calculeaza ";
            this.CalculeazaTaxa.UseVisualStyleBackColor = true;
            this.CalculeazaTaxa.Click += new System.EventHandler(this.CalculeazaTaxa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NormaPoluare.Properties.Resources.car5;
            this.pictureBox1.Location = new System.Drawing.Point(9, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 206);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxaPoluareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taxaPoluareToolStripMenuItem
            // 
            this.taxaPoluareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.taxaPoluareToolStripMenuItem.Name = "taxaPoluareToolStripMenuItem";
            this.taxaPoluareToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.taxaPoluareToolStripMenuItem.Text = "&Taxa Poluare";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculeazaTaxa);
            this.Controls.Add(this.CapacitateCilindrica);
            this.Controls.Add(this.ValoareTaxa);
            this.Controls.Add(this.EmisiaCO2);
            this.Controls.Add(this.AnFabricatie);
            this.Controls.Add(this.Norma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Taxa Poluare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Norma;
        private System.Windows.Forms.ComboBox AnFabricatie;
        private System.Windows.Forms.TextBox EmisiaCO2;
        private System.Windows.Forms.TextBox ValoareTaxa;
        private System.Windows.Forms.TextBox CapacitateCilindrica;
        private System.Windows.Forms.Button CalculeazaTaxa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taxaPoluareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

