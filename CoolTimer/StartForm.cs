using System;
using System.Windows.Forms;

namespace CoolTimer
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            for(int i = 1; i < 200; i++) { cbLimit.Items.Add(i); }
            cbLimit.SelectedIndex = 99;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(date.Value.Date + time.Value.TimeOfDay, Convert.ToInt32(cbLimit.SelectedItem.ToString()));
            mainForm.Show();
            this.Hide();
        }
    }
}