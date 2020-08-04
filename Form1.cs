using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMALL_LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Books adbok = new Add_Books();
            adbok.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Books se = new Search_Books();
            se.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_Books up = new Update_Books();
            up.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
