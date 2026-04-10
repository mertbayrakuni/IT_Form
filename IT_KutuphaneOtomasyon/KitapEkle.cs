namespace IT_KutuphaneOtomasyon
{
    public partial class KitapEkle : Form
    {
        private Book _gelenBook;

        public KitapEkle()
        {
            InitializeComponent();
            ApplyPinkTheme();
        }

        public KitapEkle(Book book)
        {
            InitializeComponent();
            _gelenBook = book;
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

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            if (_gelenBook != null)
            {
                this.Text = "Kitap Güncelle";
                btnGonder.Text = "Güncelle";
                txtBaslik.Text = _gelenBook.Title;
                txtYazar.Text = _gelenBook.Author;
                txtISBN.Text = _gelenBook.ISBN;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaslik.Text) || string.IsNullOrWhiteSpace(txtYazar.Text) || string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = new Book
            {
                Title = txtBaslik.Text.Trim(),
                Author = txtYazar.Text.Trim(),
                ISBN = txtISBN.Text.Trim()
            };

            if (btnGonder.Text == "Güncelle")
            {
                DataBank.Books.Remove(_gelenBook);
                this.Close();
            }

            DataBank.Books.Add(book);
            txtBaslik.Text = txtYazar.Text = txtISBN.Text = string.Empty;
            txtBaslik.Focus();
        }
    }
}
