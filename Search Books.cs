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
    public partial class Search_Books : Form
    {
        public Search_Books()
        {
            InitializeComponent();
        }

        private void addBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Search_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.AddBooks' table. You can move, or remove it, as needed.
            this.addBooksTableAdapter.Fill(this.libraryDataSet.AddBooks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value;
            int index;
            value = Microsoft.VisualBasic.Interaction.InputBox("Book Id.",
                "Find Book");
            index = addBooksBindingSource.Find("Book Id", value);
            addBooksBindingSource.Position = index;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
           
        }
    }
}
