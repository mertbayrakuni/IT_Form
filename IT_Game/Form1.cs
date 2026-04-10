namespace IT_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ApplyPinkTheme();
        }

        private void ApplyPinkTheme()
        {
            this.BackColor = Color.FromArgb(255, 235, 245);
            this.Text = "🐎 At Yarışı 🏆";

            Label lblTitle = new Label
            {
                Text = "🐎  AT  YARIŞI  🏆",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.DeepPink,
                BackColor = Color.Transparent,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(130, 5),
                Size = new Size(740, 48)
            };
            this.Controls.Add(lblTitle);
            lblTitle.BringToFront();

            Color[] laneColors = [
                Color.FromArgb(255, 218, 225),
                Color.FromArgb(255, 182, 193),
                Color.FromArgb(240, 150, 170)
            ];
            int[] laneY = [60, 200, 332];
            int[] laneH = [140, 132, 133];

            for (int i = 0; i < 3; i++)
            {
                Panel lane = new Panel
                {
                    Location = new Point(0, laneY[i]),
                    Size = new Size(955, laneH[i]),
                    BackColor = laneColors[i]
                };
                this.Controls.Add(lane);
                lane.SendToBack();
            }

            btnBaslat.BackColor = Color.DeepPink;
            btnBaslat.ForeColor = Color.White;
            btnBaslat.FlatStyle = FlatStyle.Flat;
            btnBaslat.FlatAppearance.BorderColor = Color.HotPink;
            btnBaslat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            btnBitis.BackColor = Color.MediumVioletRed;
            btnBitis.ForeColor = Color.White;
            btnBitis.FlatStyle = FlatStyle.Flat;
            btnBitis.FlatAppearance.BorderColor = Color.DarkMagenta;
            btnBitis.Font = new Font("Segoe UI", 7F, FontStyle.Bold);

            pbAt1.BackColor = laneColors[0];
            pbAt1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAt2.BackColor = laneColors[1];
            pbAt2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAt3.BackColor = laneColors[2];
            pbAt3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrRace.Start();
        }

        private void tmrRace_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += random.Next(5, 25);
            pbAt2.Left += random.Next(5, 25);
            pbAt3.Left += random.Next(5, 25);

            if (pbAt1.Right >= btnBitis.Left)
            {
                tmrRace.Stop();
                MessageBox.Show("At 1 kazandı!");
            }
            else if (pbAt2.Right >= btnBitis.Left)
            {
                tmrRace.Stop();
                MessageBox.Show("At 2 kazandı!");
            }
            else if (pbAt3.Right >= btnBitis.Left)
            {
                tmrRace.Stop();
                MessageBox.Show("At 3 kazandı!");
            }
        }
    }
}
