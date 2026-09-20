using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EltonBabayevFormsApp2
{
    public partial class Form1 : Form
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s.]+(\.[^@\s.]+)+\z",
            RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Zehmet olmasa e-poct unvanini duzgun daxil edin", "Xəbərdarlıq",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmailRegex.IsMatch(email))
            {
                MessageBox.Show("E-poct duzgundur", "Uğurlu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Daxil edilen e poct yanlisdir", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}