namespace IT_RunTimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnClickMe = new Button();
            btnClickMe.Text = "Click Me";
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Location = new Point(50, 50);
            btnClickMe.Width = 100;
            btnClickMe.Height = 50;

            this.Controls.Add(btnClickMe);
            btnClickMe.Click += btnClickMe_Click;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked! Here is Even More Buttons!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Text = $"Button {i},{j}";
                    btn.Name = $"btn_{i}_{j}";
                    btn.Location = new Point(50 + j * 110, 120 + i * 60);
                    btn.Width = 100;
                    btn.Height = 50;
                    this.Controls.Add(btn);
                    btn.Click += btnDynamic_Click;
                }
            }
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == Color.HotPink) 
            {
                clickedButton.BackColor = Color.Orange;
            }
            else
            {
                clickedButton.BackColor = Color.HotPink;
            }
            MessageBox.Show($"You clicked {clickedButton.Text}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
