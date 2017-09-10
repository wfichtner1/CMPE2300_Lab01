namespace CMPE2300_Lab01
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
            this.UI_PictureBox = new System.Windows.Forms.PictureBox();
            this.UI_RichText = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UI_LoadButton = new System.Windows.Forms.ToolStripButton();
            this.UI_DecodeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.UI_GoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_PictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_PictureBox
            // 
            this.UI_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PictureBox.BackColor = System.Drawing.Color.Black;
            this.UI_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.UI_PictureBox.Name = "UI_PictureBox";
            this.UI_PictureBox.Size = new System.Drawing.Size(586, 316);
            this.UI_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UI_PictureBox.TabIndex = 0;
            this.UI_PictureBox.TabStop = false;
            // 
            // UI_RichText
            // 
            this.UI_RichText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_RichText.Location = new System.Drawing.Point(12, 334);
            this.UI_RichText.Name = "UI_RichText";
            this.UI_RichText.Size = new System.Drawing.Size(586, 96);
            this.UI_RichText.TabIndex = 0;
            this.UI_RichText.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_LoadButton,
            this.UI_DecodeComboBox,
            this.toolStripComboBox1,
            this.UI_GoButton,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 479);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UI_LoadButton
            // 
            this.UI_LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_LoadButton.Name = "UI_LoadButton";
            this.UI_LoadButton.Size = new System.Drawing.Size(82, 22);
            this.UI_LoadButton.Text = "Load Image...";
            // 
            // UI_DecodeComboBox
            // 
            this.UI_DecodeComboBox.Items.AddRange(new object[] {
            "Decode Image",
            "Decode Text"});
            this.UI_DecodeComboBox.Name = "UI_DecodeComboBox";
            this.UI_DecodeComboBox.Size = new System.Drawing.Size(121, 25);
            this.UI_DecodeComboBox.Text = "Decode Image";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "with 1 Bit, Red",
            "with 1 Bit, Blue",
            "with 1 Bit, Green",
            "with 1 Bit, RGB"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Text = "with 1 Bit, Red";
            // 
            // UI_GoButton
            // 
            this.UI_GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_GoButton.Image = ((System.Drawing.Image)(resources.GetObject("UI_GoButton.Image")));
            this.UI_GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_GoButton.Name = "UI_GoButton";
            this.UI_GoButton.Size = new System.Drawing.Size(29, 22);
            this.UI_GoButton.Text = "Go!";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 504);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UI_RichText);
            this.Controls.Add(this.UI_PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_PictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_PictureBox;
        private System.Windows.Forms.RichTextBox UI_RichText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UI_LoadButton;
        private System.Windows.Forms.ToolStripComboBox UI_DecodeComboBox;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton UI_GoButton;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

