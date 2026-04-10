namespace IT_KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        private enum ListMode { None, Users, Books }
        private ListMode _currentMode = ListMode.None;

        public Form1()
        {
            InitializeComponent();
            ApplyPinkTheme();
        }

        private void ApplyPinkTheme()
        {
            this.BackColor = Color.FromArgb(255, 235, 245);

            Label lblTitle = new Label
            {
                Text = "📚  KÜTÜPHANE OTOMASYONU",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.DeepPink,
                BackColor = Color.Transparent,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 27),
                Size = new Size(800, 30)
            };
            this.Controls.Add(lblTitle);
            lblTitle.BringToFront();

            menuStrip1.BackColor = Color.HotPink;
            menuStrip1.ForeColor = Color.White;
            profilToolStripMenuItem.ForeColor = Color.White;
            kitapToolStripMenuItem.ForeColor = Color.White;

            lbListe.BackColor = Color.FromArgb(255, 218, 225);
            lbListe.ForeColor = Color.FromArgb(100, 0, 60);
            lbListe.Font = new Font("Segoe UI", 10F);
            lbListe.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProfilEkle().ShowDialog();
            _currentMode = ListMode.Users;
            RefreshUserList();
        }

        private void profilListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentMode = ListMode.Users;
            RefreshUserList();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KitapEkle().ShowDialog();
            _currentMode = ListMode.Books;
            RefreshBookList();
        }

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentMode = ListMode.Books;
            RefreshBookList();
        }

        private void tsmiGuncelle_Click(object sender, EventArgs e)
        {
            if (_currentMode == ListMode.Users && lbListe.SelectedItem is User user)
            {
                new ProfilEkle(user).ShowDialog();
                RefreshUserList();
            }
            else if (_currentMode == ListMode.Books && lbListe.SelectedItem is Book book)
            {
                new KitapEkle(book).ShowDialog();
                RefreshBookList();
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {
            if (_currentMode == ListMode.Users && lbListe.SelectedItem is User user)
            {
                DialogResult dr = MessageBox.Show($"{user} profilini silmek istediğinize emin misiniz?", "Profil Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DataBank.Users.Remove(user);
                    RefreshUserList();
                }
            }
            else if (_currentMode == ListMode.Books && lbListe.SelectedItem is Book book)
            {
                DialogResult dr = MessageBox.Show($"{book} kitabını silmek istediğinize emin misiniz?", "Kitap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DataBank.Books.Remove(book);
                    RefreshBookList();
                }
            }
        }

        private void RefreshUserList()
        {
            lbListe.Items.Clear();
            foreach (var user in DataBank.Users)
                lbListe.Items.Add(user);
        }

        private void RefreshBookList()
        {
            lbListe.Items.Clear();
            foreach (var book in DataBank.Books)
                lbListe.Items.Add(book);
        }
    }
}

