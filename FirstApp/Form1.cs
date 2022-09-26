using FirstApp.Properties;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you ready?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


            // if(result == DialogResult.Yes)

            btn_apply.Text = result.ToString();
        }





        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.BackColor = SystemColors.MenuBar;

            else if (e.Button == MouseButtons.Right)
                BackColor = Color.FromKnownColor(KnownColor.Bisque);

            else if (e.Button == MouseButtons.Middle)
                // BackColor = Color.Aquamarine;
                BackColor = Color.FromArgb(65, 212, 163);
        }




        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.ForestGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DeepSkyBlue;
        }







        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;

            timer.Start();
            // timer.Stop();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }



        private void btn_add_label_Click(object sender, EventArgs e)
        {
            int x = Random.Shared.Next(290, 600);
            int y = Random.Shared.Next(10, 370);

            Label label = new Label
            {
                Text = "New label",
                Size = new Size(50, 25),
                Location = new Point(x, y),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.BlanchedAlmond
            };

            label.Click += (s, e) =>
            {
                (s as Label)?.Dispose();
            };


            Controls.Add(label);
        }






        bool state = false;

        private void btn_changeBackImg_Click(object sender, EventArgs e)
        {
            BackgroundImage = state
                ? Resources.Azerbaijan_Satellite_Map
                : Resources.Flag_map_of_Azerbaijan;

            state = !state;
        }
    }
}