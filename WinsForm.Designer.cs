namespace FrogsInSwampWinFormsApp
{
    partial class WinsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinsForm));
            WinsPictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            winsInfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)WinsPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // WinsPictureBox
            // 
            WinsPictureBox.Dock = DockStyle.Fill;
            WinsPictureBox.Image = (Image)resources.GetObject("WinsPictureBox.Image");
            WinsPictureBox.Location = new Point(3, 3);
            WinsPictureBox.Name = "WinsPictureBox";
            WinsPictureBox.Size = new Size(378, 273);
            WinsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            WinsPictureBox.TabIndex = 0;
            WinsPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(WinsPictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(winsInfoLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(384, 311);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // winsInfoLabel
            // 
            winsInfoLabel.AutoSize = true;
            winsInfoLabel.Dock = DockStyle.Fill;
            winsInfoLabel.Location = new Point(3, 279);
            winsInfoLabel.Name = "winsInfoLabel";
            winsInfoLabel.Size = new Size(378, 32);
            winsInfoLabel.TabIndex = 1;
            winsInfoLabel.Text = "label1";
            // 
            // WinsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "WinsForm";
            Text = "Вы выиграли!";
            ((System.ComponentModel.ISupportInitialize)WinsPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox WinsPictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label winsInfoLabel;
    }
}