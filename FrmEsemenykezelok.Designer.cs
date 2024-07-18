namespace WFA24071802
{
    partial class FrmEsemenykezelok
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            pnlColors = new Panel();
            tlpColors = new TableLayoutPanel();
            label1 = new Label();
            pbxYellow = new PictureBox();
            pbxRed = new PictureBox();
            pbxBlue = new PictureBox();
            pbxGreen = new PictureBox();
            btnButton = new Button();
            lblCoords = new Label();
            tlpMain.SuspendLayout();
            pnlColors.SuspendLayout();
            tlpColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 5;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpMain.Controls.Add(pnlColors, 3, 1);
            tlpMain.Controls.Add(btnButton, 1, 1);
            tlpMain.Controls.Add(lblCoords, 1, 0);
            tlpMain.Location = new Point(13, 13);
            tlpMain.Margin = new Padding(4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpMain.Size = new Size(988, 427);
            tlpMain.TabIndex = 0;
            // 
            // pnlColors
            // 
            pnlColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlColors.BackColor = Color.Beige;
            pnlColors.BorderStyle = BorderStyle.FixedSingle;
            pnlColors.Controls.Add(tlpColors);
            pnlColors.Location = new Point(693, 45);
            pnlColors.Name = "pnlColors";
            pnlColors.Size = new Size(241, 335);
            pnlColors.TabIndex = 1;
            // 
            // tlpColors
            // 
            tlpColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpColors.ColumnCount = 1;
            tlpColors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpColors.Controls.Add(label1, 0, 0);
            tlpColors.Controls.Add(pbxYellow, 0, 4);
            tlpColors.Controls.Add(pbxRed, 0, 1);
            tlpColors.Controls.Add(pbxBlue, 0, 3);
            tlpColors.Controls.Add(pbxGreen, 0, 2);
            tlpColors.Location = new Point(3, 3);
            tlpColors.Name = "tlpColors";
            tlpColors.RowCount = 5;
            tlpColors.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpColors.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpColors.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpColors.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpColors.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpColors.Size = new Size(233, 327);
            tlpColors.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 65);
            label1.TabIndex = 1;
            label1.Text = "Kattints valamelyik színes téglalapra!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxYellow
            // 
            pbxYellow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxYellow.BackColor = Color.Gold;
            pbxYellow.Location = new Point(3, 265);
            pbxYellow.Margin = new Padding(3, 5, 3, 5);
            pbxYellow.Name = "pbxYellow";
            pbxYellow.Padding = new Padding(0, 5, 0, 5);
            pbxYellow.Size = new Size(227, 57);
            pbxYellow.TabIndex = 0;
            pbxYellow.TabStop = false;
            // 
            // pbxRed
            // 
            pbxRed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxRed.BackColor = Color.OrangeRed;
            pbxRed.Location = new Point(3, 70);
            pbxRed.Margin = new Padding(3, 5, 3, 5);
            pbxRed.Name = "pbxRed";
            pbxRed.Padding = new Padding(0, 5, 0, 5);
            pbxRed.Size = new Size(227, 55);
            pbxRed.TabIndex = 0;
            pbxRed.TabStop = false;
            // 
            // pbxBlue
            // 
            pbxBlue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxBlue.BackColor = Color.DodgerBlue;
            pbxBlue.Location = new Point(3, 200);
            pbxBlue.Margin = new Padding(3, 5, 3, 5);
            pbxBlue.Name = "pbxBlue";
            pbxBlue.Padding = new Padding(0, 5, 0, 5);
            pbxBlue.Size = new Size(227, 55);
            pbxBlue.TabIndex = 0;
            pbxBlue.TabStop = false;
            // 
            // pbxGreen
            // 
            pbxGreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxGreen.BackColor = Color.LimeGreen;
            pbxGreen.Location = new Point(3, 135);
            pbxGreen.Margin = new Padding(3, 5, 3, 5);
            pbxGreen.Name = "pbxGreen";
            pbxGreen.Padding = new Padding(0, 5, 0, 5);
            pbxGreen.Size = new Size(227, 55);
            pbxGreen.TabIndex = 0;
            pbxGreen.TabStop = false;
            // 
            // btnButton
            // 
            btnButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnButton.BackColor = Color.Firebrick;
            btnButton.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnButton.ForeColor = Color.White;
            btnButton.Location = new Point(52, 45);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(586, 335);
            btnButton.TabIndex = 0;
            btnButton.Text = "ez a gomb felirata";
            btnButton.UseVisualStyleBackColor = false;
            // 
            // lblCoords
            // 
            lblCoords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCoords.Location = new Point(52, 0);
            lblCoords.Name = "lblCoords";
            lblCoords.Size = new Size(586, 42);
            lblCoords.TabIndex = 1;
            lblCoords.Text = "Mozgasd az egeret a gomb felett!";
            lblCoords.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmEsemenykezelok
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 453);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmEsemenykezelok";
            Text = "Eseménykezelők";
            tlpMain.ResumeLayout(false);
            pnlColors.ResumeLayout(false);
            tlpColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Button btnButton;
        private Label lblCoords;
        private Panel pnlColors;
        private Label label1;
        private PictureBox pbxYellow;
        private PictureBox pbxBlue;
        private PictureBox pbxGreen;
        private PictureBox pbxRed;
        private TableLayoutPanel tlpColors;
    }
}
