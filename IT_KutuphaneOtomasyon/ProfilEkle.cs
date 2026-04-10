namespace IT_KutuphaneOtomasyon
{
    public partial class ProfilEkle : Form
    {
        private User _gelenUser;

        public ProfilEkle()
        {
            InitializeComponent();
            ApplyPinkTheme();
        }

        public ProfilEkle(User user)
        {
            InitializeComponent();
            _gelenUser = user;
            ApplyPinkTheme();
        }

        private void ApplyPinkTheme()
        {
            this.BackColor = Color.FromArgb(255, 235, 245);
            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                    lbl.ForeColor = Color.DeepPink;
                if (c is TextBox txt)
                {
                    txt.BackColor = Color.FromArgb(255, 218, 225);
                    txt.ForeColor = Color.FromArgb(100, 0, 60);
                }
                if (c is Button btn)
                {
                    btn.BackColor = Color.DeepPink;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.HotPink;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void ProfilEkle_Load(object sender, EventArgs e)
        {
            if (_gelenUser != null)
            {
                this.Text = "Profil Güncelle";
                btnGonder.Text = "Güncelle";
                txtAd.Text = _gelenUser.FirstName;
                txtSoyad.Text = _gelenUser.LastName;
                txtEmail.Text = _gelenUser.Email;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                FirstName = txtAd.Text.Trim(),
                LastName = txtSoyad.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (btnGonder.Text == "Güncelle")
            {
                DataBank.Users.Remove(_gelenUser);
                this.Close();
            }

            DataBank.Users.Add(user);
            txtAd.Text = txtSoyad.Text = txtEmail.Text = string.Empty;
            txtAd.Focus();
        }
    }
}

