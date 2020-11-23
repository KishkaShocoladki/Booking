using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking3
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            List<string> user = MainForm.MySelect("SELECT DISTINCT `Name` FROM `users`");
            comboBox1.Items.AddRange(user.ToArray());
            comboBox2.Items.Clear();
            comboBox2.Items.Add("");
            List<string> city = MainForm.MySelect("SELECT DISTINCT `City` FROM `users`");
            comboBox2.Items.AddRange(city.ToArray());
            comboBox3.Items.Clear();
            comboBox3.Items.Add("");
            List<string> age = MainForm.MySelect("SELECT DISTINCT `Age` FROM `users`");
            comboBox3.Items.AddRange(age.ToArray());
           
            List<string> us = MainForm.MySelect("SELECT `Name`, `City`, `Age`, `Login` FROM `users`");
            for (int i = 0; i < us.Count; i = i + 4)
            {
                string[] row = new string[4];
                row[0] = us[i];
                row[1] = us[i + 1];
                row[2] = us[i + 2];
                row[3] = us[i + 3];
                dataGridView1.Rows.Add(row);
            }
        }

        private void users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                List<string> us = MainForm.MySelect("SELECT `Name`, `City`, `Age`, `Login` FROM `users` WHERE Name ='" + comboBox1.Text + "'");
                for (int i = 0; i < us.Count; i = i + 4)
                {
                    string[] row = new string[4];
                    row[0] = us[i];
                    row[1] = us[i + 1];
                    row[2] = us[i + 2];
                    row[3] = us[i + 3];
                    dataGridView1.Rows.Add(row);
                }
            }
            if (!string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                List<string> us = MainForm.MySelect("SELECT `Name`, `City`, `Age`, `Login` FROM `users` WHERE City ='" + comboBox2.Text + "'");
                for (int i = 0; i < us.Count; i = i + 4)
                {
                    string[] row = new string[4];
                    row[0] = us[i];
                    row[1] = us[i + 1];
                    row[2] = us[i + 2];
                    row[3] = us[i + 3];
                    dataGridView1.Rows.Add(row);
                }
            }
            if (!string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                List<string> us = MainForm.MySelect("SELECT `Name`, `City`, `Age`, `Login` FROM `users` WHERE Age ='" + comboBox3.Text + "'");
                for (int i = 0; i < us.Count; i = i + 4)
                {
                    string[] row = new string[4];
                    row[0] = us[i];
                    row[1] = us[i + 1];
                    row[2] = us[i + 2];
                    row[3] = us[i + 3];
                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}
