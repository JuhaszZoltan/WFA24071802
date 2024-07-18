using System.Diagnostics;

namespace WFA24071802
{
    public partial class FrmEsemenykezelok : Form
    {
        static Random rnd = new();
        Stopwatch sw = new();

        public FrmEsemenykezelok()
        {
            InitializeComponent();
            btnButton.MouseEnter += BtnButton_MouseEnter;
            btnButton.MouseLeave += BtnButton_MouseLeave;
            btnButton.MouseMove += BtnButton_MouseMove;
            btnButton.Click += BtnButton_Click;

            pbxBlue.Click += PictureBox_Click;
            pbxGreen.Click += PictureBox_Click;
            pbxRed.Click += PictureBox_Click;
            pbxYellow.Click += PictureBox_Click;
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            this.BackColor = (sender as Control).BackColor;
        }

        private void BtnButton_Click(object? sender, EventArgs e)
        {
            btnButton.Text = btnButton.Text.ToUpper();
        }

        private void BtnButton_MouseMove(object? sender, MouseEventArgs e)
        {
            lblCoords.Text = $"kurzorpozíció: X: {Cursor.Position.X:0000}; Y: {Cursor.Position.Y:0000}";

            if (sw.Elapsed >= new TimeSpan(0, 0, 0, 0, 500))
            {
                this.BackColor = Color.FromArgb(
                    red: rnd.Next(256),
                    green: rnd.Next(256),
                    blue: rnd.Next(256));
                sw.Restart();
            }
        }

        private void BtnButton_MouseLeave(object? sender, EventArgs e)
        {
            btnButton.BackColor = Color.Firebrick;
            lblCoords.Text = "Mozgasd az egeret a gomb felett!";
            btnButton.Text = btnButton.Text.ToLower();
            this.BackColor = Color.White;
            sw.Stop();
        }

        private void BtnButton_MouseEnter(object? sender, EventArgs e)
        {
            sw.Start();
            btnButton.BackColor = Color.ForestGreen;
        }
    }
}
